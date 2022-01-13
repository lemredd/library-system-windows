using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static OnlineLibrary.Validators;

namespace OnlineLibrary
{
    public delegate void ChildToParentFormEventHandler();

    public partial class FormLibrarySystem : Form
    {
        public FormLibrarySystem()
        {
            InitializeComponent();
        }

        private DataTable accountLookup(Boolean borrowerSignIn)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LibrarianConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                if (borrowerSignIn) cmd.CommandText = "select * from accounts where username = @username and password = @password";
                else cmd.CommandText = "select * from librarians where username = @username and password = @password";
                cmd.Parameters.AddWithValue("@username", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }

        private void signIn(bool borrowerSignIn = true)
        {
            if (areTextBoxesNotEmpty(new TextBox[] { textBoxEmail, textBoxPassword }))
            {
                if (borrowerSignIn)
                {
                    DataTable lookupResult = accountLookup(borrowerSignIn);

                    if (lookupResult.Rows.Count > 0)
                    {
                        this.Hide();
                        BorrowerUI borrowerUI = new BorrowerUI();
                        borrowerUI.logoutEvent += Form_LogoutEvent;
                        borrowerUI.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password.");
                    }
                }
                else
                {
                    DataTable lookupResult = accountLookup(borrowerSignIn);

                    if (lookupResult.Rows.Count > 0)
                    {
                        this.Hide();
                        LibrarianUI librarianUI = new LibrarianUI();
                        librarianUI.logoutEvent += Form_LogoutEvent;
                        librarianUI.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password.");
                    }
                }           
            }
            else
            {
                MessageBox.Show("Please enter your credentials.");
            }
        }

        private void buttonAdminSignIn_Click(object sender, EventArgs e)
        {
            signIn(borrowerSignIn: false);
        }

            private void buttonSignInStudent_Click(object sender, EventArgs e)
        {
            signIn();
        }

        private void Form_LogoutEvent()
        {
            this.Show();
        }

        private void linkLabelForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you are a borrower:\nContact the librarian about your password\n\n" +
                            "If you are the librarian:\nContact the IT personnel about your password");
        }
    }
}
