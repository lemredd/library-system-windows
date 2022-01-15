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

namespace OnlineLibrary.Panel_LibrarianUI
{
    public partial class UserControl_Books : UserControl
    {
        public UserControl_Books()
        {
            InitializeComponent();
            populateTable();
        }

        private void populateTable()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from books";
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(dataTable);

                dgvBooks.DataSource = dataTable;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LibrarianMenus.BookMenus.Form_AddOrEditBook addBook = new LibrarianMenus.BookMenus.Form_AddOrEditBook();
            addBook.FormClosing += AddBook_FormClosing;
            addBook.Show();
        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            populateTable();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                LibrarianMenus.BookMenus.Form_AddOrEditBook addBook = new LibrarianMenus.BookMenus.Form_AddOrEditBook(dgvBooks.CurrentRow);
                addBook.FormClosing += AddBook_FormClosing;
                addBook.Show();
            }
            else MessageBox.Show("Please select a book from the table below.");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure about deleting this book? Any schedules related with this book will also be deleted.", "Delete Book", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("BookDelete", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@book_id", Convert.ToInt32(dgvBooks.CurrentRow.Cells["txtBookID"].Value));

                        cmd.ExecuteNonQuery();
                    }
                }
            } else MessageBox.Show("Please select a book from the table below.");

            populateTable();
        }
    }
}
