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

namespace OnlineLibrary.Panel_LibrarianUI
{
    public partial class UserControl_Schedule : UserControl
    {
        public UserControl_Schedule()
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
                cmd.CommandText = $"select schedules.*, books.title, books.isbn from schedules inner join accounts on schedules.account_id = accounts.account_id inner join books on schedules.book_id = books.book_id";
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(cmd).Fill(dataTable);

                dgvSchedules.DataSource = dataTable;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow != null)
            {
                LibrarianMenus.ScheduleMenus.Form_EditSchedule editSchedule = new LibrarianMenus.ScheduleMenus.Form_EditSchedule(dgvSchedules.CurrentRow);
                editSchedule.FormClosing += EditSchedule_FormClosing; 
                editSchedule.Show();
            }
            else MessageBox.Show("Please select a schedule from the table below.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure about this?", "Delete Schedule", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
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
            else MessageBox.Show("Please select a schedule from the table below.");
        }

        private void EditSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            populateTable();
        }
    }
}
