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
    public partial class LibrarianUI : Form
    {
        private UserControl activeContent;
        public event ChildToParentFormEventHandler logoutEvent;

        public LibrarianUI()
        {
            InitializeComponent();
            loadContent(new Panel_LibrarianUI.UserControl_Books());
        }

        private void loadContent(UserControl contentToLoad)
        {
            if (activeContent != null)
            {
                activeContent = null;
            }

            activeContent = contentToLoad;
            contentToLoad.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(contentToLoad);
            this.panelContent.Tag = contentToLoad;
            contentToLoad.BringToFront();
            contentToLoad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Profile());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Books());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Schedule());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibrarianUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.logoutEvent();
            }
            else e.Cancel = true;
        }
    }
}
