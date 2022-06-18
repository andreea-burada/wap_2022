using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using practice_1.Entities;

namespace practice_1
{
    public partial class PrincipalForm : Form
    {
        #region Attributes
        protected List<Specialty> specialtyList;
        protected List<Doctor> doctorList;
        protected string listFileName = "\\Specialties.txt";
        protected string dbConnection = "..\\..\\Database\\Doctors.db";
        #endregion
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            // load specialties
            try
            {
                specialtyList = Specialty.readListFromFile(listFileName);
            }
            catch (FileNotFoundException fnfex)
            {
                MessageBox.Show(fnfex.Message, "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
            // list view
            doctorList = new List<Doctor>();
            lvDoctors.View = View.Details;
            lvDoctors.FullRowSelect = true;
            lvDoctors.Columns.Add("Id");
            lvDoctors.Columns.Add("Name");
            lvDoctors.Columns.Add("Birthday");
            lvDoctors.Columns.Add("Wage");
            lvDoctors.Columns.Add("Specialty");

            lvDoctors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvDoctors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            displayList();
        }
        private void displayList()
        {
            // sort the list again
            doctorList.Sort();
            lvDoctors.Items.Clear();
            int index = 0;
            foreach(Doctor doctor in doctorList)
            {
                ListViewItem newItem = new ListViewItem(doctor.Id.ToString());
                newItem.SubItems.Add(doctor.Name);
                newItem.SubItems.Add(doctor.BirthDate.ToShortDateString());
                newItem.SubItems.Add(doctor.Wage.ToString());
                if (doctor.IdSpecialty == -1)
                    newItem.SubItems.Add("Unknown");
                else
                    newItem.SubItems.Add(specialtyList[doctor.IdSpecialty].Name);

                lvDoctors.Items.Add(newItem);
                lvDoctors.Items[index++].Tag = doctor;
            }

            lvDoctors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvDoctors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            bool newDoctor = true;
            Doctor toAddEdit = null;
            if (lvDoctors.SelectedItems.Count > 0)
            {
                newDoctor = false;
                toAddEdit = lvDoctors.SelectedItems[0].Tag as Doctor;
            }
            else
            {
                toAddEdit = new Doctor(String.Empty, DateTime.Now, Decimal.Zero);
            }
            Form doctorAddEditWindow = new DoctorForm(toAddEdit, specialtyList);
            if(doctorAddEditWindow.ShowDialog() == DialogResult.OK)
            {
                if (newDoctor == true)
                    doctorList.Add(toAddEdit);
                displayList();
            }
        }

        private void lvDoctors_DoubleClick(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedItems.Count == 1)
            {
                Doctor toEdit = lvDoctors.SelectedItems[0].Tag as Doctor;
                Form doctorAddEditWindow = new DoctorForm(toEdit, specialtyList);
                if (doctorAddEditWindow.ShowDialog() == DialogResult.OK)
                {
                    displayList();
                }
            }
        }
    }
}
