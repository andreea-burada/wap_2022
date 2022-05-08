using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seminar_10.Entitites;

namespace seminar_10
{
    public partial class RoomForm : Form
    {
        public Room _room;
        public RoomForm()
        {
            InitializeComponent();
        }

        public RoomForm(Room selected_room) : this()
        {
            _room = selected_room;
            this.ActiveControl = roomId_Edit;
        }

        // when it loads
        private void RoomForm_Load(object sender, EventArgs e)
        {
            roomId_Edit.Value = _room.Id;
            roomName_Edit.Text = _room.Name;
            checkHasProjector_Edit.Checked = _room.HasProjector;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // check if name is empty
            if (errorProvider.GetError(roomName_Edit) == string.Empty && errorProvider.GetError(roomId_Edit) == string.Empty)
            {
                _room.Id = (int)roomId_Edit.Value;
                _room.Name = roomName_Edit.Text;
                _room.HasProjector = checkHasProjector_Edit.Checked;
                
            }
            else
            {
                
                MessageBox.Show(
                    "You have invalid input data. Please try again.", 
                    "Invalid Room Input", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void roomId_Edit_Validating(object sender, CancelEventArgs e)
        {
            if ((int)roomId_Edit.Value == 0)
            {
                e.Cancel = true;
               // roomId_Edit.Focus();
                errorProvider.SetError(roomId_Edit, "ID cannot be 0");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void roomName_Edit_Validating(object sender, CancelEventArgs e)
        {
            if (roomName_Edit.Text == string.Empty)
            {
                e.Cancel = true;
               // roomName_Edit.Focus();
                errorProvider.SetError(roomName_Edit, "Name cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }


    }
}
