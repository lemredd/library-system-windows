using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibrary
{
    public partial class FormLibrarySystem : Form
    {
        public FormLibrarySystem()
        {
            InitializeComponent();
        }
        private void picboxLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelFormCtrlEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFormCtrlPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdminSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarian_UI f2= new Librarian_UI();
            f2.Show();
        }

        private void buttonSignInStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowerUI borrowerUI = new BorrowerUI();
            borrowerUI.Show();
        }
    }
}
