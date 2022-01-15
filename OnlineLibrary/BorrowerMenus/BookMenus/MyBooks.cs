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
    public partial class MyBooks : UserControl
    {
        private readonly SessionUser currentSessionUser;

        public MyBooks(SessionUser currentSessionUser)
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
                cmd.CommandText = $"select schedules.*, books.title, books.isbn from schedules inner join accounts on schedules.account_id = accounts.account_id inner join books on schedules.book_id = books.book_id where accounts.account_id = @account_id";
                cmd.Parameters.AddWithValue("@account_id", this.currentSessionUser.sessionUserID);
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(dataTable);

                dgvSchedules.DataSource = dataTable;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow != null)
            {
                if (dgvSchedules.CurrentRow.Cells["txtStatus"].Value.ToString() == "approved") MessageBox.Show("This schedule has already been approved. Contact the Librarian to delete this schedule and return the book.");
                else
                {
                    if (MessageBox.Show("Are you sure about this?", "Delete Schedule", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
                        {
                            conn.Open();

                            SqlCommand cmd = new SqlCommand("ScheduleDelete", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sched_id", (int)dgvSchedules.CurrentRow.Cells["txtScheduleID"].Value);

                            cmd.ExecuteNonQuery();

                            populateTable();
                        }
                    }
                }
            }
            else MessageBox.Show("Please choose a schedule from the table above.");
        }
    }
}
