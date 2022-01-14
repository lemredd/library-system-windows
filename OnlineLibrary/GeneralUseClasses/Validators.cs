using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibrary
{
    internal class Validators
    {
        public static Boolean areTextBoxesNotEmpty(TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "") return false;
            }
            return true;
        }
    }
}
