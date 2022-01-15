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

namespace OnlineLibrary.LibrarianMenus
{
    public partial class Form_BorrowerAccounts : Form
    {
        public Form_BorrowerAccounts()
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
                cmd.CommandText = "select * from accounts";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvBorrowerAccounts.DataSource = dataTable;
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AccountMenus.Form_AddOrEditAccount addOrEditAccount = new AccountMenus.Form_AddOrEditAccount();
            addOrEditAccount.ReloadTableAfterClosing += AddorEditAccount_ReloadTableAfterClosing;
            addOrEditAccount.ShowDialog();
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            if (dgvBorrowerAccounts.CurrentRow != null)
            {
                AccountMenus.Form_AddOrEditAccount addOrEditAccount = new AccountMenus.Form_AddOrEditAccount(dgvBorrowerAccounts.CurrentRow);
                addOrEditAccount.ReloadTableAfterClosing += AddorEditAccount_ReloadTableAfterClosing;
                addOrEditAccount.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Choose an account to edit from the list above.");
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            if (dgvBorrowerAccounts.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure about deleting this account? It would also delete any schedules set by this account.", "Delete Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LocalConn))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("AccountDelete", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@account_id", Convert.ToInt32(dgvBorrowerAccounts.CurrentRow.Cells["txtAccountID"].Value));

                        cmd.ExecuteNonQuery();
                    }

                    populateTable();
                }
            }
            else
            {
                MessageBox.Show("Please Choose an account to edit from the list above.");
            }
        }

        private void AddorEditAccount_ReloadTableAfterClosing()
        {
            populateTable();
        }
    }
}
