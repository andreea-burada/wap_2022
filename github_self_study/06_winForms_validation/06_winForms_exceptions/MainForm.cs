using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_winForms_exceptions.Entities;

namespace _06_winForms_exceptions
{
    public partial class MainForm : Form
    {
        #region Attributes
        private int? numerator = null;
        private int? denominator = null;
        private Fraction _fraction;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                _fraction = new Fraction(tbNumerator.Text, tbDenumerator.Text);

                float _result = _fraction.result();
                lblResult.Text = Math.Round(_result, 3).ToString();
            }

            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (InvalidNumeratorException ine)
            {
                MessageBox.Show(ine.Message, "Invalid Numerator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (InvalidDenominatorException ide)
            {
                MessageBox.Show(ide.Message, "Invalid Denominator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (DivideByZeroException dbyze)
            {
                MessageBox.Show(dbyze.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNumerator.Clear();
            tbDenumerator.Clear();
            lblResult.Text = "";
        }

        private void tbDivisionSign_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
