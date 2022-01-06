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
    public partial class Librarian_UI : Form
    {
        private UserControl activeContent = null;

        public Librarian_UI()
        {
            InitializeComponent();
        }

        private void loadContent(UserControl contentToLoad)
        {
            if (activeContent != null)
            {
                activeContent = null;
            }

            activeContent = contentToLoad;
            contentToLoad.Dock = DockStyle.Fill;
            this.panellibrarian.Controls.Add(contentToLoad);
            this.panellibrarian.Tag = contentToLoad;
            contentToLoad.BringToFront();
            contentToLoad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Profile());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Books());
        }

        private void panellibrarian_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Schedule());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadContent(new Panel_LibrarianUI.UserControl_Settings());
        }
    }
}
