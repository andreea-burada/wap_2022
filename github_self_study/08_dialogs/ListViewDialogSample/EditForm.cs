using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListViewBasicSample.Entities;

namespace ListViewBasicSample
{
    public partial class EditForm : Form
    {
        private readonly Participant _participant;
        public EditForm(Participant participant)
        {
            InitializeComponent();
            _participant = participant;

         }

        // after opening the window -> display old data
        private void EditForm_Load(object sender, System.EventArgs e)
        {
            tbLastName_Edit.Text = _participant.LastName;
            tbFirstName_Edit.Text = _participant.FirstName;
            dtp_Edit.Value = _participant.BirthDate;
        }

        private void btnCancel_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Edit_Click(object sender, EventArgs e)
        {
            _participant.FirstName = tbFirstName_Edit.Text;
            _participant.LastName = tbLastName_Edit.Text;
            _participant.BirthDate = dtp_Edit.Value;
        }
    }
}
