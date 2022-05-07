using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using seminar_10.Entitites;

namespace seminar_10
{
    public partial class BuildingForm : Form
    {

        private Building _building;
        public BuildingForm()
        {
            InitializeComponent();
            _building = new Building();
        }

        private void displayRooms()
        {
            _building.Rooms.Sort();
            dgvRooms.Rows.Clear();
            // we display one by one
            foreach (Room toDisplay in _building.Rooms)
            {
                int index = dgvRooms.Rows.Add(new object[] { toDisplay.Id, toDisplay.Name, toDisplay.HasProjector });
                dgvRooms.Rows[index].Tag = toDisplay;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNew = true;
            Room toAddEdit = new Room(0, string.Empty, false);
            // we check if we have something selected
            if (dgvRooms.SelectedRows.Count > 0)
            {
                toAddEdit = dgvRooms.SelectedRows[0].Tag as Room;
                isNew = false;
            }
            if (dgvRooms.SelectedRows.Count > 1)
            {
                MessageBox.Show("You cannot edit multiple rows at the same time.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RoomForm roomFormWindow = new RoomForm(toAddEdit);
            try
            {
                if (roomFormWindow.ShowDialog() == DialogResult.OK)
                {

                    if (isNew == true)
                        _building.Rooms.Add(toAddEdit);
                    displayRooms();
                }
            }
            catch (Exception ex) { 
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before you delete.", "Invalid Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string message = "Are you sure you want to delete ";
            message += dgvRooms.SelectedRows.Count == 1 ? "1 row?" : (dgvRooms.SelectedRows.Count.ToString() + " rows?");
            if (MessageBox.Show(message, "Delete Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // we delete the rows
                foreach(DataGridViewRow toDeleteRow in dgvRooms.SelectedRows)
                {
                    _building.Rooms.Remove((Room)toDeleteRow.Tag);
                }
                displayRooms();
            }
        }

        // XML serialization
        private void miXML_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "XML Files | *.xml";
            saveWindow.Title = "Save list as XML file";

            // if we click ok
            if(saveWindow.ShowDialog() == DialogResult.OK)
            {
                // we serialize the data
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Building));
                using (FileStream outFile = File.Create(saveWindow.FileName))
                    xmlSerializer.Serialize(outFile, _building);
            }
        }

        //XML deserialization
        private void miXML_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openWindow = new OpenFileDialog();
            openWindow.Filter = "XML Files | *.xml";
            openWindow.Title = "Open XML file";

            //if we click ok -> we deserialize
            if(openWindow.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(Building));
                using (FileStream inFile = File.OpenRead(openWindow.FileName))
                {
                    _building = (Building)xmlDeserializer.Deserialize(inFile);
                    displayRooms();
                }
            }
        }

        // binary serialization
        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Binary Files | *.bin";
            saveWindow.Title = "Save list as Binary file";

            // if we click ok
            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                // we serialize the data
               BinaryFormatter binSerializer = new BinaryFormatter();
                using (FileStream outFile = File.Create(saveWindow.FileName))
                   binSerializer.Serialize(outFile, _building);
            }
        }

        // binary deserializer
        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openWindow = new OpenFileDialog();
            openWindow.Filter = "Binary Files | *.bin";
            openWindow.Title = "Open Binary file";

            //if we click ok -> we deserialize
            if (openWindow.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binDeserializer = new BinaryFormatter();
                using (FileStream inFile = File.OpenRead(openWindow.FileName))
                {
                    _building = (Building)binDeserializer.Deserialize(inFile);
                    displayRooms();
                }
            }
        }

    }
}
