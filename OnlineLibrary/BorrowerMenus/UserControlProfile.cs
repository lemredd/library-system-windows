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
using static OnlineLibrary.Validators;


namespace OnlineLibrary.BorrowerPanels
{
    public partial class UserControlProfile : UserControl
    {
        private readonly SessionUser currentSessionUser;

        public UserControlProfile(SessionUser currentSessionUser)
        {
            InitializeComponent();
            this.currentSessionUser = currentSessionUser;
            populateFields();
        }

        private void populateFields()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from accounts where account_id = @account_id";
                cmd.Parameters.AddWithValue("@account_id", this.currentSessionUser.sessionUserID);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                tbUsername.Text = dataTable.Rows[0]["username"].ToString();
                tbPassword.Text = dataTable.Rows[0]["password"].ToString();
            }
        }

        private void toggleTextBoxes()
        {
            tbUsername.Enabled = !tbUsername.Enabled;
            tbPassword.Enabled = !tbPassword.Enabled;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            toggleTextBoxes();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (areTextBoxesNotEmpty(new TextBox[] {tbUsername, tbPassword}))
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("AccountAddOrEdit", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@account_id", this.currentSessionUser.sessionUserID),
                        new SqlParameter("@username", tbUsername.Text),
                        new SqlParameter("@password", tbPassword.Text)
                    });

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modified Successfully.");
                    toggleTextBoxes();
                }
            }
        }
        
    }
}
