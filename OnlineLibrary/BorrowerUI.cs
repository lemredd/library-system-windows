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
        public BorrowerUI()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        loadContent(new BorrowerPanels.UserControlMyBooks());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerPanels.UserControlProfile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadContent(new BorrowerPanels.UserControlSettings());
        }
    }
}
