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

namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    public partial class Form_BookDetails : Form
    {
        private DataGridViewRow selectedBook;

        public Form_BookDetails(DataGridViewRow selectedBook)
        {
            InitializeComponent();
            this.selectedBook = selectedBook;

            tbTitle.Text = $"{this.selectedBook.Cells["txtTitle"].Value}";
            tbAuthor.Text = $"{selectedBook.Cells["txtAuthor"].Value}";
            dtpDateAuth.Value = DateTime.Parse(selectedBook.Cells["txtDateAuthored"].Value.ToString());
            tbCategories.Text = $"{selectedBook.Cells["txtCategories"].Value}";
            numIsbn.Value = Convert.ToInt32(selectedBook.Cells["txtISBN"].Value);
            numCopiesLeft.Value = Convert.ToInt32(selectedBook.Cells["txtCopiesLeft"].Value);
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
    }
}
