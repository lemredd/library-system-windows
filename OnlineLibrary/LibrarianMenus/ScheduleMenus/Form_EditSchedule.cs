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

namespace OnlineLibrary.LibrarianMenus.ScheduleMenus
{
    public partial class Form_EditSchedule : Form
    {
        private readonly DataGridViewRow selectedSchedule;

        public Form_EditSchedule(DataGridViewRow selectedSchedule)
        {
            InitializeComponent();
            this.selectedSchedule = selectedSchedule;
            populateFields();
        }

        private void populateFields()
        {
            dtDateStart.Value = (DateTime) this.selectedSchedule.Cells["txtDateStart"].Value;
            dtDateEnd.Value = (DateTime)this.selectedSchedule.Cells["txtDateEnd"].Value;
            dtDateEnd.MinDate = (DateTime)this.selectedSchedule.Cells["txtDateStart"].Value;

            for (int i = 0; i < cbStatus.Items.Count; i++)
                if (this.selectedSchedule.Cells["txtStatus"].Value.ToString() == cbStatus.Items[i].ToString()) cbStatus.SelectedIndex = i;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ScheduleEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("@sched_id", (int)this.selectedSchedule.Cells["txtScheduleID"].Value),
                    new SqlParameter("@date_start", dtDateStart.Value.Date),
                    new SqlParameter("@date_end", dtDateEnd.Value.Date),
                    new SqlParameter("@status", cbStatus.SelectedItem.ToString())
                });

                cmd.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
