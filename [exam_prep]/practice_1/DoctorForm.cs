using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice_1.Entities;
using System.Windows.Forms;

//The instances of the Doctor class will be added using a secondary form,
//in which the user will be able to optionally choose the specialty of the
//doctor using a ListBox control.

//The following validations will be performed: the age of the doctor
//should be at least 25 and below 70, the name should be at least 3
//characters long, wage>=0, numeric. The validation errors will be displayed
//next to the corresponding fields when the user changes the focus to another
//control, as well as when the user clicks the “Add” button. The application
//should not crash if the user inputs invalid information.

//The instances of the class will be stored in a List<T> collection
//and will be displayed in the main form using a ListView control,
//configured to look similar to a table.

namespace practice_1
{
    public partial class DoctorForm : Form
    {
        #region Attributes
        protected List<Specialty> specialtyList;
        protected Doctor doctorAddEdit;
        #endregion
        public DoctorForm()
        {
            InitializeComponent();
        }
        public DoctorForm(Doctor dc, List<Specialty> sL) : this()
        {
            specialtyList = sL;
            doctorAddEdit = dc;
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // load specialty list box
            foreach (Specialty specialty in specialtyList)
            {
                lboxSpecialty.Items.Add(specialty.Name);
            }

            tbName.Text = doctorAddEdit.Name;
            dtpBirthDay.Value = doctorAddEdit.BirthDate;
            if (dtpBirthDay.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                dtpBirthDay.Value = dtpBirthDay.Value.AddYears(-30);
            }
            tbWage.Text = doctorAddEdit.Wage.ToString();
            lboxSpecialty.SelectedIndex = doctorAddEdit.IdSpecialty;

            // focus all boxes
            tbName.Select();
            dtpBirthDay.Select();
            tbWage.Select();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (errorpDoctor.GetError(tbName) == String.Empty &&
                errorpDoctor.GetError(tbWage) == String.Empty &&
                errorpDoctor.GetError(dtpBirthDay) == String.Empty &&
                errorpDoctor.GetError(lboxSpecialty) == String.Empty)
            {
                doctorAddEdit.Name = tbName.Text;
                doctorAddEdit.Wage = Decimal.Parse(tbWage.Text);
                doctorAddEdit.BirthDate = dtpBirthDay.Value;
                if (lboxSpecialty.SelectedIndex < 0)
                    doctorAddEdit.IdSpecialty = -1;
                else
                    doctorAddEdit.IdSpecialty = lboxSpecialty.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Input data is incorrect. Please check and try again.", "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length < 3)
            {
                errorpDoctor.SetError(tbName, "Name length must be greater than 2");
                //e.Cancel = true;
            }
            else
            {
                errorpDoctor.SetError(tbName, String.Empty);
            }
        }

        private void dtpBirthDay_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.Year - dtpBirthDay.Value.Year < 25 ||
                DateTime.Now.Year - dtpBirthDay.Value.Year > 70)
            {
                errorpDoctor.SetError(dtpBirthDay, "Age must be between 25 and 70");
            }
            else
            {
                errorpDoctor.SetError(dtpBirthDay, String.Empty);
            }
        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (errorpDoctor.GetError(tbName) == String.Empty &&
                    errorpDoctor.GetError(tbWage) == String.Empty &&
                    errorpDoctor.GetError(dtpBirthDay) == String.Empty &&
                    errorpDoctor.GetError(lboxSpecialty) == String.Empty)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = false;
        }

        private void tbWage_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(tbWage.Text, out decimal outD) == false)
            {
                errorpDoctor.SetError(tbWage, "Wage is decimal value");
            }
            else
            {
                errorpDoctor.SetError(tbWage, String.Empty);
            }
        }
    }
}
