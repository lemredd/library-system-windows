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

namespace OnlineLibrary.LibrarianMenus.AccountMenus
{
    public partial class Form_AddOrEditAccount : Form
    {
        private readonly DataGridViewRow accountToEdit;
        public event ChildToParentFormEventHandler ReloadTableAfterClosing;

        public Form_AddOrEditAccount()
        {
            InitializeComponent();
            this.Text = "Add Account";
            btnAddOrEdit.Text = "Add";
        }

        public Form_AddOrEditAccount(DataGridViewRow accountToEdit)
        {
            InitializeComponent();
            this.accountToEdit = accountToEdit;

            this.Text = "Edit Account";
            btnAddOrEdit.Text = "Edit";
            tbUsername.Text = this.accountToEdit.Cells["txtUsername"].Value.ToString();
            tbPassword.Text = this.accountToEdit.Cells["txtPassword"].Value.ToString();
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if (accountToEdit != null)
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
                            new SqlParameter("@account_id", Convert.ToInt32(accountToEdit.Cells["txtAccountID"].Value)),
                            new SqlParameter("@username", tbUsername.Text),
                            new SqlParameter("@password", tbPassword.Text)
                        });

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                } else MessageBox.Show("Make sure the required fields are not empty.");
            }
            else
            {
                if (areTextBoxesNotEmpty(new TextBox[] { tbUsername, tbPassword }))
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("AccountAddOrEdit", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@account_id", DbType.Int32),
                            new SqlParameter("@username", tbUsername.Text),
                            new SqlParameter("@password", tbPassword.Text)
                        });

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                } else MessageBox.Show("Make sure the required fields are not empty.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddOrEditAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ReloadTableAfterClosing();
        }
    }
}
