namespace seminar_10
{
    partial class RoomForm
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
            this.checkHasProjector_Edit = new System.Windows.Forms.CheckBox();
            this.roomId_Edit = new System.Windows.Forms.NumericUpDown();
            this.roomName_Edit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomId_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // checkHasProjector_Edit
            // 
            this.checkHasProjector_Edit.AutoSize = true;
            this.checkHasProjector_Edit.Location = new System.Drawing.Point(103, 105);
            this.checkHasProjector_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.checkHasProjector_Edit.Name = "checkHasProjector_Edit";
            this.checkHasProjector_Edit.Size = new System.Drawing.Size(90, 17);
            this.checkHasProjector_Edit.TabIndex = 0;
            this.checkHasProjector_Edit.Text = "Has Projector";
            this.checkHasProjector_Edit.UseVisualStyleBackColor = true;
            // 
            // roomId_Edit
            // 
            this.roomId_Edit.Location = new System.Drawing.Point(103, 35);
            this.roomId_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.roomId_Edit.Name = "roomId_Edit";
            this.roomId_Edit.Size = new System.Drawing.Size(230, 20);
            this.roomId_Edit.TabIndex = 1;
            this.roomId_Edit.Tag = "";
            this.roomId_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.roomId_Edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roomName_Edit
            // 
            this.roomName_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName_Edit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.roomName_Edit.Location = new System.Drawing.Point(103, 69);
            this.roomName_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.roomName_Edit.Name = "roomName_Edit";
            this.roomName_Edit.Size = new System.Drawing.Size(230, 20);
            this.roomName_Edit.TabIndex = 4;
            this.roomName_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(303, 161);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(226, 161);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(73, 29);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(69, 37);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(21, 72);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 13);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Room Name";
            // 
            // RoomForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 206);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.roomName_Edit);
            this.Controls.Add(this.roomId_Edit);
            this.Controls.Add(this.checkHasProjector_Edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Room";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomId_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkHasProjector_Edit;
        private System.Windows.Forms.NumericUpDown roomId_Edit;
        private System.Windows.Forms.TextBox roomName_Edit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
    }
}