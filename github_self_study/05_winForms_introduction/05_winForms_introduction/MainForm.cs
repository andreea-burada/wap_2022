using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_winForms_introduction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbNumericTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // disable the abilty to type letters or symbols other than numbers
        private void tbNumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);

            //char[] valid = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '\b' };

            List<char> valid = new List<char>();
            valid.Add('.');
            valid.Add('\b');
            for (var i = 0; i < 10; i++)
            {
                valid.Add((char)(i + '0'));
            }

            if (!valid.Contains(e.KeyChar))
            {
                // Consume this invalid key
                e.Handled = true;
            }
        }
    }
}
