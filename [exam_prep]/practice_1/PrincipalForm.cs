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
using System.Data.SQLite;
using System.Xml.Serialization;

namespace practice_1
{
    public partial class PrincipalForm : Form
    {
        #region Attributes
        protected List<Specialty> specialtyList;
        protected List<Doctor> doctorList;
        protected string listFileName = "\\Specialties.txt";
        protected const string ConnectionString = "Data Source=..\\..\\Database\\Doctors.db";
        protected int currentDoctorIndex;
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
            Doctor.sortStyle = "Default";
            loadFromDatabase();
            displayList();
        }

        private void loadFromDatabase()
        {
            var query = "select * from Doctors";    // query with multiple rows
            using(SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                dbConnection.Open();

                var command = new SQLiteCommand(query, dbConnection);

                using(SQLiteDataReader currentRow = command.ExecuteReader())
                {
                    // we parse row by row
                    while (currentRow.Read())
                    {
                        
                        int id = int.Parse(currentRow["Id"].ToString());
                        string name = currentRow["Name"].ToString();
                        DateTime birthday = DateTime.Parse(currentRow["Birthdate"].ToString());
                        decimal wage = Decimal.Parse(currentRow["Wage"].ToString());
                        int sId = int.Parse(currentRow["SpecialtyId"].ToString());

                        Doctor toAdd = new Doctor(id, name, birthday, wage, sId);
                        doctorList.Add(toAdd);
                    }
                }
                query = "select max(Id) from Doctors";
                command = new SQLiteCommand(query, dbConnection);
                bool succeeded = int.TryParse(command.ExecuteScalar().ToString(), out int maxId);
                if (succeeded == false)
                    maxId = 0;
                Doctor.setIdCount(maxId);
            }
        }

        private void addToDatabase(Doctor toAdd)
        {
            var query = "insert into Doctors(Id, Name, Birthdate, Wage, SpecialtyId)" +
                " values (@id, @name, @birthdate, @wage, @specialtyid)";
            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                // open connection
                dbConnection.Open();

                // create statement/command
                var command = new SQLiteCommand(query, dbConnection);

                // add parameters
                command.Parameters.AddWithValue("@id", toAdd.Id);
                command.Parameters.AddWithValue("@name", toAdd.Name);
                command.Parameters.AddWithValue("@birthdate", toAdd.BirthDate);
                command.Parameters.AddWithValue("@wage", toAdd.Wage);
                command.Parameters.AddWithValue("@specialtyid", toAdd.IdSpecialty);
               
                // execute query - no return
                command.ExecuteNonQuery();
            }
        }
        private void updateFromDatabase(Doctor toUpdate)
        {
            // insert into Doctors(Id, Name, Birthdate, Wage, SpecialtyId)" +
            //" values (@id, @name, @birthdate, @wage, @specialtyid)
            var query = "update Doctors set Id=@id, Name=@name, Birthdate=@birthdate, Wage=@wage, SpecialtyId=@specialtyid " 
                + "where Id=@currentid";
            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                // open connection
                dbConnection.Open();

                // create statement/command
                var command = new SQLiteCommand(query, dbConnection);

                // add parameters
                command.Parameters.AddWithValue("@currentid", toUpdate.Id);
                command.Parameters.AddWithValue("@id", toUpdate.Id);
                command.Parameters.AddWithValue("@name", toUpdate.Name);
                command.Parameters.AddWithValue("@birthdate", toUpdate.BirthDate);
                command.Parameters.AddWithValue("@wage", toUpdate.Wage);
                command.Parameters.AddWithValue("@specialtyid", toUpdate.IdSpecialty);

                // execute query - no return
                command.ExecuteNonQuery();
            }
        }
        private void deleteFromDatabase(Doctor toDelete)
        {
            var query = "delete from Doctors where Id = @id";

            using(SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                // open
                dbConnection.Open();

                var command = new SQLiteCommand(query, dbConnection);

                // add parameters
                command.Parameters.AddWithValue("@id", toDelete.Id);

                // execute
                command.ExecuteNonQuery();

                dbConnection.Close();
            }
        }

        private void displayList()
        {
            // sort the list again
            doctorList.Sort(new comparerDoctor());
            lvDoctors.Items.Clear();
            int index = 0;
            foreach (Doctor doctor in doctorList)
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

// Allow the user to print a list with all the doctors and their assigned specialties.
// The user should be able to preview the list and to make changes to the page settings.
        private void printDoctorList()
        {

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
            if (doctorAddEditWindow.ShowDialog() == DialogResult.OK)
            {
                if (newDoctor == true)
                {
                    doctorList.Add(toAddEdit);
                    // add to db
                    addToDatabase(toAddEdit);
                }
                else
                {
                    // update in db
                    updateFromDatabase(toAddEdit);
                }
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
                    // update in db
                    updateFromDatabase(toEdit);
                    displayList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // determine how many items to delete
            if (lvDoctors.SelectedItems.Count < 0)
            {
                MessageBox.Show("Please select at least one row in order to delete it", "Delete Error");
            }
            else
            {
                String message = "Are you sure you want to delete ";
                message += lvDoctors.SelectedItems.Count == 1 ? "1 row?" : (lvDoctors.SelectedItems.Count.ToString() + " rows?");
                if (MessageBox.Show(message, "Delete Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    if (lvDoctors.SelectedItems.Count == 1)
                    {
                        Doctor toDelete = lvDoctors.SelectedItems[0].Tag as Doctor;
                        // delete from DB
                        deleteFromDatabase(toDelete);
                        doctorList.Remove(toDelete);
                        
                        displayList();
                    }
                    else
                    {
                        foreach (ListViewItem toDelete in lvDoctors.SelectedItems)
                        {
                            // delete from DB
                            deleteFromDatabase((Doctor)toDelete.Tag);
                            doctorList.Remove((Doctor)toDelete.Tag);
                        }
                        displayList();
                    }
                }
            }
        }

        private void toolStripXMLExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog xmlSaveDialog = new SaveFileDialog();
            xmlSaveDialog.Title = "Save List as XML File";
            xmlSaveDialog.Filter = "XML File | *.xml";

            if (xmlSaveDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Doctor>));
                using (FileStream outFile = File.Create(xmlSaveDialog.FileName)) 
                {
                    xmlSer.Serialize(outFile, doctorList);
                }
            }
        }

        private void btnSortDefault_Click(object sender, EventArgs e)
        {
            Doctor.sortStyle = "Default";
            displayList();
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            Doctor.sortStyle = "Name";
            displayList();
        }

        private void btnSortBirthdate_Click(object sender, EventArgs e)
        {
            Doctor.sortStyle = "Birthdate";
            displayList();
        }

        private void toolStripPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;   // getting the settings of the document

            if(pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;   // saving the changes
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // font
            Font printFont = new Font("Century Gothic", 10);
            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            // x and y coordinates for the printing area rectangle
            var marginLeft = pageSettings.Margins.Left; // x
            var marginTop = pageSettings.Margins.Top;   // y

            // landscape?
            if (pageSettings.Landscape == true)
            {
                var tmp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = tmp;
            }
            const int rowHeight = 30;
            var columnWidth = printAreaWidth / 5;   // 5 - no. columns

            StringFormat layout = new StringFormat(StringFormatFlags.LineLimit);
            layout.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;

            // table header
            // reset horizontal drawing coordinate
            var currentX = marginLeft;

            // id
            // draw cell border
            e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
            e.Graphics.DrawString("Doctor ID",
                printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
            // update x coord
            currentX += columnWidth;

            // name
            // draw cell border
            e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
            e.Graphics.DrawString("Doctor Name",
                printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
            // update x coord
            currentX += columnWidth;

            // birthdate
            // draw cell border
            e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
            e.Graphics.DrawString("Birth Date",
                printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
            // update x coord
            currentX += columnWidth;

            // wage
            // draw cell border
            e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
            e.Graphics.DrawString("Wage",
                printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
            // update x coord
            currentX += columnWidth;

            // specialty id
            // draw cell border
            e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
            e.Graphics.DrawString("Specialty",
                printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);

            // update y coord
            currentY += rowHeight;

            while (currentDoctorIndex < doctorList.Count)
            {
                // reset horizontal drawing coordinate
               currentX = marginLeft;

                // id
                // draw cell border
                e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(doctorList[currentDoctorIndex].Id.ToString(),
                    printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
                // update x coord
                currentX += columnWidth;
             
                // name
                // draw cell border
                e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(doctorList[currentDoctorIndex].Name,
                    printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
                // update x coord
                currentX += columnWidth;

                // birthdate
                // draw cell border
                e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(doctorList[currentDoctorIndex].BirthDate.ToShortDateString(),
                    printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
                // update x coord
                currentX += columnWidth;

                // wage
                // draw cell border
                e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(doctorList[currentDoctorIndex].Wage.ToString(),
                    printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);
                // update x coord
                currentX += columnWidth;

                // specialty id
                // draw cell border
                string specialty = specialtyList.Find(x => x.Id == doctorList[currentDoctorIndex].IdSpecialty).Name;
                e.Graphics.DrawRectangle(Pens.DarkGray, currentX, currentY, columnWidth, rowHeight);
                e.Graphics.DrawString(specialty,
                    printFont, Brushes.Maroon, new RectangleF(currentX, currentY, columnWidth, rowHeight), layout);

                currentDoctorIndex++;
                // update y coord
                currentY += rowHeight;

                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           currentDoctorIndex = 0;
        }

        private void toolStripPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. " +
                    "Make sure you currently have access to a printer. " +
                    "A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void toolStripPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void toolStripBarChart_Click(object sender, EventArgs e)
        {
            List<int> specialtyCount = new List<int>();
            foreach(Specialty currentSpecialty in specialtyList)
            {
                int countX = doctorList.Count(x => x.IdSpecialty == currentSpecialty.Id);
                specialtyCount.Add(countX);
            }
            Form barChartWindow = new BarChart(specialtyList, specialtyCount);
            barChartWindow.Show();
        }
    }
}
