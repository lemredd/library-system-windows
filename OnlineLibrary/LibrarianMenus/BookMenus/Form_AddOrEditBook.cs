using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OnlineLibrary.LibrarianMenus.BookMenus
{
    public partial class Form_AddOrEditBook : Form
    {
        private string selectedImagePath;
        private DataGridViewRow selectedBook;
        private Image retainImageWhileEditing;

        public Form_AddOrEditBook()
        {
            InitializeComponent();

            this.Text = "Add Book";
            btnAddOrEditBook.Text = "Add Book";
        }
        public Form_AddOrEditBook(DataGridViewRow selectedBook)
        {
            InitializeComponent();

            this.selectedBook = selectedBook;
            this.Text = "Edit Book";
            btnAddOrEditBook.Text = "Edit Book";
            tbTitle.Text = $"{this.selectedBook.Cells["txtTitle"].Value}";
            tbAuthor.Text = $"{selectedBook.Cells["txtAuthor"].Value}";
            dtpDateAuth.Value = DateTime.Parse(selectedBook.Cells["txtDateAuthored"].Value.ToString());
            tbCategories.Text = $"{selectedBook.Cells["txtCategories"].Value}";
            numIsbn.Value = Convert.ToInt64(selectedBook.Cells["txtISBN"].Value);
            numCopiesLeft.Value = Convert.ToInt32(selectedBook.Cells["txtCopiesLeft"].Value);
            loadImage();            
        }

        private void loadImage()
        {
            if (this.selectedBook.Cells["imgImage"].Value != DBNull.Value)
            { 
                Byte[] imageBlob = new Byte[0];
                imageBlob = (Byte[]) this.selectedBook.Cells["imgImage"].Value;
                MemoryStream streamImageBlob = new MemoryStream(imageBlob);
                pbBookCover.Image = Image.FromStream(streamImageBlob);
                this.retainImageWhileEditing = pbBookCover.Image;
            }
        }

        private void chooseImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.selectedImagePath = ofd.FileName;
                    pbBookCover.ImageLocation = ofd.FileName;
                }
            }
        }

        private byte[] imageBlob()
        {
            if (this.selectedImagePath != null)
            {
                FileStream fsBlobFile = new FileStream(this.selectedImagePath, FileMode.Open, FileAccess.Read);
                byte[] byteBlobData = new byte[fsBlobFile.Length];
                fsBlobFile.Read(byteBlobData, 0, byteBlobData.Length);
                fsBlobFile.Close();

                return byteBlobData;
            }
            else if (this.retainImageWhileEditing != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                this.retainImageWhileEditing.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
            return new byte[0];
        }

        private void saveBook()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
            {
                byte[] imageBlobData = imageBlob();
                SqlParameter imageParameter;

                SqlCommand cmd = new SqlCommand("BookAddOrEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (this.selectedBook != null) cmd.Parameters.AddWithValue("@book_id", Convert.ToInt32(this.selectedBook.Cells["txtBookID"].Value));
                else cmd.Parameters.AddWithValue("@book_id", DbType.Int32);
                cmd.Parameters.AddRange(new SqlParameter[]
                {                    
                    new SqlParameter("@title", tbTitle.Text),
                    new SqlParameter("@author", tbAuthor.Text),
                    new SqlParameter("@date_authored", dtpDateAuth.Value),
                    new SqlParameter("@categories", tbCategories.Text),
                    new SqlParameter("@isbn", numIsbn.Value),
                    new SqlParameter("@copies_left", numCopiesLeft.Value)
                });
                if (imageBlobData.Length > 0) imageParameter = new SqlParameter("@image", SqlDbType.VarBinary, imageBlobData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, imageBlobData);
                else imageParameter = new SqlParameter("@image", SqlDbType.VarBinary, imageBlobData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, DBNull.Value);
                cmd.Parameters.Add(imageParameter);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private void pbBookCover_DoubleClick(object sender, EventArgs e)
        {
            chooseImage();
        }

        private void btnAddOrEditBook_Click(object sender, EventArgs e)
        {
            if (Validators.areTextBoxesNotEmpty(new TextBox[] { tbTitle, tbAuthor })) saveBook();
            else MessageBox.Show("Please enter the title and author.");
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            chooseImage();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            pbBookCover.Image = new Bitmap(Properties.Resources.addcover);
            this.selectedImagePath = null;
            this.retainImageWhileEditing = null;
        }
    }
}
