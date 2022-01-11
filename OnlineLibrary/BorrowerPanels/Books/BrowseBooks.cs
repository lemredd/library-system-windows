using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibrary.BorrowerPanels
{
    public partial class UserControlBrowseBooks : UserControl
    {
        public UserControlBrowseBooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          UserControlBrowseBooks f2 = new UserControlBrowseBooks();
            f2.Show();
        }
    }
}
