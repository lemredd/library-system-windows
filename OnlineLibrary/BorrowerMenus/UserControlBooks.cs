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

namespace OnlineLibrary.BorrowerPanels
{
    public partial class UserControlBooks : UserControl
    {
        private UserControl activeContent;
        private readonly SessionUser currentSessionUser;

        public UserControlBooks(SessionUser currentSessionUser)
        {
            InitializeComponent();
            this.currentSessionUser = currentSessionUser;
            loadContent(new BorrowerMenus.BookMenus.MyBooks(this.currentSessionUser));
        }



        private void loadContent(UserControl contentToLoad)
        {
            if (activeContent != null)
            {
                activeContent = null;
            }

            activeContent = contentToLoad;
            contentToLoad.Dock = DockStyle.Fill;
            this.panelBooksContent.Controls.Add(contentToLoad);
            this.panelBooksContent.Tag = contentToLoad;
            contentToLoad.BringToFront();
            contentToLoad.Show();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerMenus.BookMenus.MyBooks(this.currentSessionUser));
        }

        private void btnBrowseBooks_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerMenus.BookMenus.BrowseBooks());
        }
    }
}
