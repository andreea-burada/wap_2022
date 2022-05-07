using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ListViewBasicSample.Entities;

namespace ListViewBasicSample
{
	internal partial class MainForm : Form
	{
		#region Attributes
		private readonly List<Participant> _participants;
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

				listViewItem.Tag = participant;

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
		}

		private void btnDelete_Click(object sender, EventArgs e)
        {
			if (lvParticipants.SelectedItems.Count == 0)
            {
				MessageBox.Show("Choose a participant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
            }

			string message = "Are you sure you want to delete the ";
			message += lvParticipants.SelectedItems.Count == 1 ? "participant?" : 
				("participants? (Count: " + lvParticipants.SelectedItems.Count.ToString() + ")");

			if (MessageBox.Show(message, "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
				_participants.Remove((Participant)lvParticipants.SelectedItems[0].Tag);
				DisplayParticipants();
            }
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
			if (lvParticipants.SelectedItems.Count == 0)
            {
				MessageBox.Show("Choose a participant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// we open a new window
			if (lvParticipants.SelectedItems.Count == 1)
			{
				EditForm editWindow = new EditForm((Participant)lvParticipants.SelectedItems[0].Tag);
				if (editWindow.ShowDialog() == DialogResult.OK)
					DisplayParticipants();
			}
            else
            {
				MessageBox.Show("You can only edit one participant at the time.", "Too many selected participants",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
        }
    }
}
