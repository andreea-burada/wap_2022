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
            if (roomName_Edit.Text == "")
            {
                MessageBox.Show("Room name cannot be empty. Please try again.", "Invalid Room Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception("Name cannot be empty.");
            }
            _room.Id = (int)roomId_Edit.Value;
            _room.Name = roomName_Edit.Text;
            _room.HasProjector = checkHasProjector_Edit.Checked;

        }
    }
}
