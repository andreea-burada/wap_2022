using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using ListViewBasicSample.Entities;

namespace ListViewBasicSample
{
	internal partial class MainForm : Form
	{
		#region Attributes
		private List<Participant> _participants;
		#endregion

		public MainForm()
		{
			InitializeComponent();

			_participants = new List<Participant>();
		}

		#region Methods
		public void DisplayParticipants()
		{
			lvParticipants.Items.Clear();

			foreach (Participant participant in _participants)
			{
				var listViewItem = new ListViewItem(participant.LastName);
				listViewItem.SubItems.Add(participant.FirstName);
				listViewItem.SubItems.Add(participant.BirthDate.ToShortDateString());

				lvParticipants.Items.Add(listViewItem);
			}
		}
		#endregion

		#region Events
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = tbFirstName.Text;
			string lastName = tbLastName.Text;
			DateTime birthDate = dtpBirthDate.Value;

			var participant = new Participant(lastName, firstName, birthDate);
			_participants.Add(participant);

			DisplayParticipants();

			tbLastName.Clear();
			tbFirstName.Clear();
			dtpBirthDate.Value = DateTime.Now;
		}

		// menu item Binary Serialization > Serialize Click action
		private void miBinSer_Ser_Click(object sender, EventArgs e)
        {
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream file_stream = File.Create("bin_serialization.bin"))
				formatter.Serialize(file_stream, _participants);
        }

		// binary deserialization
		private void miBinSer_Deser_Click(object sender, EventArgs e)
        {
			BinaryFormatter formatter = new BinaryFormatter();
			using(FileStream file_stream = File.OpenRead("bin_serialization.bin"))
            {
				_participants = (List<Participant>)formatter.Deserialize(file_stream);
				DisplayParticipants();
            }
        }



		// XML serialization
		private void miXMLSer_Ser_Click(object sender, EventArgs e)
        {
			XmlSerializer xml_ser = new XmlSerializer(typeof(List<Participant>));
			using (FileStream file_stream = File.Create("xml_serialization.xml"))
				xml_ser.Serialize(file_stream, _participants);
        }

		private void miXMLSer_Ser_Click_2(object sender, EventArgs e)
		{
			// create an instance of the open file dialog box
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "XML file | *.xml";
			saveFileDialog.Title = "Save as XML file";

			// if we click ok -> ShowDialog -> checks if we clicked OK
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				XmlSerializer xml_ser = new XmlSerializer(typeof(List<Participant>));
				using (FileStream file_stream = File.Create(saveFileDialog.FileName))
					xml_ser.Serialize(file_stream, _participants);
			}
		}

		//XML deserialization
		private void miXMLSer_Deser_Click(object sender, EventArgs e)
		{
			XmlSerializer xml_deser = new XmlSerializer(typeof(List<Participant>));
			using (FileStream file_stream = File.OpenRead("xml_serialization.xml"))
			{
				_participants = (List<Participant>)xml_deser.Deserialize(file_stream);
				DisplayParticipants();
			}
			#endregion
		}

		private void miXMLSer_Deser_Click_2(object sender, EventArgs e)
        {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML Files | *.xml";
			openFileDialog.Title = "Open XML file ...";

			if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
				XmlSerializer xml_deser = new XmlSerializer(typeof (List<Participant>));
				using (FileStream file_stream = File.OpenRead(openFileDialog.FileName))
                {
					_participants = (List<Participant>)xml_deser.Deserialize(file_stream);
					DisplayParticipants();
                }
            }
        }



		// text file save
		private void miTextFile_Export_Click(object sender, EventArgs e)
        {
			// create an instance of the open file dialog box
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file | *.txt";
			saveFileDialog.Title = "Save as text file";

			// if we click ok -> ShowDialog -> checks if we clicked OK
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// recommended approach
				using (StreamWriter file_writer = new StreamWriter(saveFileDialog.FileName))
				{
					file_writer.WriteLine("LastName, FirstName, BirthDate");

					foreach (Participant participant in _participants)
					{
                        file_writer.WriteLine("\"{0}\", \"{1}\", \"{2}\"",
                            participant.LastName.Replace("\"", "\"\""),
                            participant.FirstName.Replace("\"", "\"\""),
                            participant.BirthDate.ToShortDateString());

                        //file_writer.WriteLine("\"{0}\", \"{1}\", \"{2}\"",
                        //	participant.LastName,
                        //	participant.FirstName,
                        //	participant.BirthDate.ToShortDateString());
                    }
				}
			}
        }
	}
}
