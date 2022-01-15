using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    public partial class Form_BookDetails : Form
    {
        private DataGridViewRow selectedBook;
        private SessionUser currentSessionUser;

        public Form_BookDetails(DataGridViewRow selectedBook, SessionUser currentSessionUser)
        {
            InitializeComponent();

            this.selectedBook = selectedBook;
            this.currentSessionUser = currentSessionUser;
            populateFields();
        }

        private void populateFields()
        {
            tbTitle.Text = $"{this.selectedBook.Cells["txtTitle"].Value}";
            tbAuthor.Text = $"{this.selectedBook.Cells["txtAuthor"].Value}";
            dtpDateAuth.Value = DateTime.Parse(this.selectedBook.Cells["txtDateAuthored"].Value.ToString());
            tbCategories.Text = $"{this.selectedBook.Cells["txtCategories"].Value}";
            numIsbn.Value = Convert.ToInt64(this.selectedBook.Cells["txtISBN"].Value);
            numCopiesLeft.Value = Convert.ToInt32(this.selectedBook.Cells["txtCopiesLeft"].Value);
            dtDateStart.MinDate = DateTime.Today;
            dtDateEnd.MinDate = DateTime.Today;
            loadImage();
        }

        private void loadImage()
        {
            if (this.selectedBook.Cells["imgImage"].Value != DBNull.Value)
            {
                Byte[] imageBlob = new Byte[0];
                imageBlob = (Byte[])this.selectedBook.Cells["imgImage"].Value;
                MemoryStream streamImageBlob = new MemoryStream(imageBlob);
                pbBookCover.Image = Image.FromStream(streamImageBlob);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (DateTime.Today != dtDateStart.Value.Date) MessageBox.Show("Make sure the start date is same as the date now.\n\n" +
                $"Date now: {DateTime.Today}\nDate Start: {dtDateStart.Value.Date}");
            else
            {
                Int32 compareDates = DateTime.Compare(dtDateStart.Value.Date, dtDateEnd.Value.Date);

                if (compareDates > 0) MessageBox.Show("The end date of your borrowing schedule should not be earlier than the start date.");
                else
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("ScheduleAdd", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@account_id", (Int32) this.currentSessionUser.sessionUserID),
                            new SqlParameter("@book_id", (Int32) this.selectedBook.Cells["txtBookID"].Value),
                            new SqlParameter("@date_start", dtDateStart.Value.Date),
                            new SqlParameter("@date_end", dtDateEnd.Value.Date),
                            new SqlParameter("@status", "pending")
                        });

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Request Successfully Submitted.");
                        this.Close();
                    }
                }
            } 
        }
    }
}
