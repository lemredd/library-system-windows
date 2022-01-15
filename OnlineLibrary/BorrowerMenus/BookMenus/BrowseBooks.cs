using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibrary.BorrowerMenus.BookMenus
{
    public partial class BrowseBooks : UserControl
    {
        private SessionUser currentSessionUser;

        public BrowseBooks(SessionUser currentSessionUser)
        {
            InitializeComponent();

            this.currentSessionUser = currentSessionUser;
            populateTable();
        }

        private void populateTable()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"select * from books";

                DataTable dataTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(dataTable);

                dgvBooks.DataSource = dataTable;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                Form_BookDetails bookDetails = new Form_BookDetails(dgvBooks.CurrentRow, this.currentSessionUser);
                bookDetails.Show();
            } else MessageBox.Show("Please select a book from the table below.");
        }
    }
}
