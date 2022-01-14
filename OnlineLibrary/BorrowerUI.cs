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

    public partial class BorrowerUI : Form
    {
        private UserControl activeContent;
        public event ChildToParentFormEventHandler logoutEvent;
        private readonly SessionUser currentSessionUser;

        public BorrowerUI(SessionUser currentSessionUser)
        {
            InitializeComponent();
            this.currentSessionUser = currentSessionUser;
            loadContent(new BorrowerPanels.UserControlBooks(this.currentSessionUser));
        }

        private void BorrowerUI_Load(object sender, EventArgs e)
        {

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

        private void btnBooks_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerPanels.UserControlBooks(this.currentSessionUser));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerPanels.UserControlProfile(this.currentSessionUser));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrowerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.logoutEvent();
            } else e.Cancel = true;
        }
    }
}
