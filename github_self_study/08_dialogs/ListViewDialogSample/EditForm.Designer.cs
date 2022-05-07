namespace ListViewBasicSample
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLastName_Edit = new System.Windows.Forms.TextBox();
            this.tbFirstName_Edit = new System.Windows.Forms.TextBox();
            this.dtp_Edit = new System.Windows.Forms.DateTimePicker();
            this.lbFirstName_Edit = new System.Windows.Forms.Label();
            this.btnCancel_Edit = new System.Windows.Forms.Button();
            this.btnOK_Edit = new System.Windows.Forms.Button();
            this.lbLastName_Edit = new System.Windows.Forms.Label();
            this.lbBirthDate_Edit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLastName_Edit
            // 
            this.tbLastName_Edit.Location = new System.Drawing.Point(126, 44);
            this.tbLastName_Edit.Name = "tbLastName_Edit";
            this.tbLastName_Edit.Size = new System.Drawing.Size(206, 20);
            this.tbLastName_Edit.TabIndex = 0;
            // 
            // tbFirstName_Edit
            // 
            this.tbFirstName_Edit.Location = new System.Drawing.Point(126, 101);
            this.tbFirstName_Edit.Name = "tbFirstName_Edit";
            this.tbFirstName_Edit.Size = new System.Drawing.Size(206, 20);
            this.tbFirstName_Edit.TabIndex = 1;
            // 
            // dtp_Edit
            // 
            this.dtp_Edit.Location = new System.Drawing.Point(126, 166);
            this.dtp_Edit.Name = "dtp_Edit";
            this.dtp_Edit.Size = new System.Drawing.Size(206, 20);
            this.dtp_Edit.TabIndex = 2;
            // 
            // lbFirstName_Edit
            // 
            this.lbFirstName_Edit.AutoSize = true;
            this.lbFirstName_Edit.Location = new System.Drawing.Point(47, 104);
            this.lbFirstName_Edit.Name = "lbFirstName_Edit";
            this.lbFirstName_Edit.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName_Edit.TabIndex = 3;
            this.lbFirstName_Edit.Text = "First Name";
            // 
            // btnCancel_Edit
            // 
            this.btnCancel_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Edit.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Edit.Location = new System.Drawing.Point(257, 227);
            this.btnCancel_Edit.Name = "btnCancel_Edit";
            this.btnCancel_Edit.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_Edit.TabIndex = 4;
            this.btnCancel_Edit.Text = "Cancel";
            this.btnCancel_Edit.UseVisualStyleBackColor = false;
            this.btnCancel_Edit.Click += new System.EventHandler(this.btnCancel_Edit_Click);
            // 
            // btnOK_Edit
            // 
            this.btnOK_Edit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOK_Edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK_Edit.ForeColor = System.Drawing.Color.White;
            this.btnOK_Edit.Location = new System.Drawing.Point(145, 227);
            this.btnOK_Edit.Name = "btnOK_Edit";
            this.btnOK_Edit.Size = new System.Drawing.Size(106, 23);
            this.btnOK_Edit.TabIndex = 5;
            this.btnOK_Edit.Text = "OK";
            this.btnOK_Edit.UseVisualStyleBackColor = false;
            this.btnOK_Edit.Click += new System.EventHandler(this.btnOK_Edit_Click);
            // 
            // lbLastName_Edit
            // 
            this.lbLastName_Edit.AutoSize = true;
            this.lbLastName_Edit.Location = new System.Drawing.Point(47, 47);
            this.lbLastName_Edit.Name = "lbLastName_Edit";
            this.lbLastName_Edit.Size = new System.Drawing.Size(58, 13);
            this.lbLastName_Edit.TabIndex = 6;
            this.lbLastName_Edit.Text = "Last Name";
            // 
            // lbBirthDate_Edit
            // 
            this.lbBirthDate_Edit.AutoSize = true;
            this.lbBirthDate_Edit.Location = new System.Drawing.Point(47, 170);
            this.lbBirthDate_Edit.Name = "lbBirthDate_Edit";
            this.lbBirthDate_Edit.Size = new System.Drawing.Size(54, 13);
            this.lbBirthDate_Edit.TabIndex = 7;
            this.lbBirthDate_Edit.Text = "Birth Date";
            // 
            // EditForm
            // 
            this.AcceptButton = this.btnOK_Edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel_Edit;
            this.ClientSize = new System.Drawing.Size(372, 290);
            this.Controls.Add(this.lbBirthDate_Edit);
            this.Controls.Add(this.lbLastName_Edit);
            this.Controls.Add(this.btnOK_Edit);
            this.Controls.Add(this.btnCancel_Edit);
            this.Controls.Add(this.lbFirstName_Edit);
            this.Controls.Add(this.dtp_Edit);
            this.Controls.Add(this.tbFirstName_Edit);
            this.Controls.Add(this.tbLastName_Edit);
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName_Edit;
        private System.Windows.Forms.TextBox tbFirstName_Edit;
        private System.Windows.Forms.DateTimePicker dtp_Edit;
        private System.Windows.Forms.Label lbFirstName_Edit;
        private System.Windows.Forms.Button btnCancel_Edit;
        private System.Windows.Forms.Button btnOK_Edit;
        private System.Windows.Forms.Label lbLastName_Edit;
        private System.Windows.Forms.Label lbBirthDate_Edit;
    }
}