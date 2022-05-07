﻿namespace ListViewBasicSample
{
	partial class MainForm
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
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miBinarySerialization = new System.Windows.Forms.ToolStripMenuItem();
            this.miBinSer_Ser = new System.Windows.Forms.ToolStripMenuItem();
            this.miBinSer_Deser = new System.Windows.Forms.ToolStripMenuItem();
            this.miXMLSerialization = new System.Windows.Forms.ToolStripMenuItem();
            this.miXMLSer_Ser = new System.Windows.Forms.ToolStripMenuItem();
            this.miXMLSer_Deser = new System.Windows.Forms.ToolStripMenuItem();
            this.miTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miTextFile_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvParticipants
            // 
            this.lvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvParticipants.FullRowSelect = true;
            this.lvParticipants.GridLines = true;
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(10, 172);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(687, 234);
            this.lvParticipants.TabIndex = 53;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Last Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birth Date";
            this.columnHeader3.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Location = new System.Drawing.Point(10, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 119);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Participant";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(501, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add Participant";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(102, 31);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(102, 72);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(467, 29);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBinarySerialization,
            this.miXMLSerialization,
            this.miTextFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miBinarySerialization
            // 
            this.miBinarySerialization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBinSer_Ser,
            this.miBinSer_Deser});
            this.miBinarySerialization.Name = "miBinarySerialization";
            this.miBinarySerialization.Size = new System.Drawing.Size(118, 20);
            this.miBinarySerialization.Text = "Binary Serialization";
            // 
            // miBinSer_Ser
            // 
            this.miBinSer_Ser.Name = "miBinSer_Ser";
            this.miBinSer_Ser.Size = new System.Drawing.Size(134, 22);
            this.miBinSer_Ser.Text = "Serialize";
            this.miBinSer_Ser.Click += new System.EventHandler(this.miBinSer_Ser_Click);
            // 
            // miBinSer_Deser
            // 
            this.miBinSer_Deser.Name = "miBinSer_Deser";
            this.miBinSer_Deser.Size = new System.Drawing.Size(134, 22);
            this.miBinSer_Deser.Text = "De-serialize";
            this.miBinSer_Deser.Click += new System.EventHandler(this.miBinSer_Deser_Click);
            // 
            // miXMLSerialization
            // 
            this.miXMLSerialization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miXMLSer_Ser,
            this.miXMLSer_Deser});
            this.miXMLSerialization.Name = "miXMLSerialization";
            this.miXMLSerialization.Size = new System.Drawing.Size(109, 20);
            this.miXMLSerialization.Text = "XML Serialization";
            // 
            // miXMLSer_Ser
            // 
            this.miXMLSer_Ser.Name = "miXMLSer_Ser";
            this.miXMLSer_Ser.Size = new System.Drawing.Size(180, 22);
            this.miXMLSer_Ser.Text = "Serialize";
            this.miXMLSer_Ser.Click += new System.EventHandler(this.miXMLSer_Ser_Click_2);
            // 
            // miXMLSer_Deser
            // 
            this.miXMLSer_Deser.Name = "miXMLSer_Deser";
            this.miXMLSer_Deser.Size = new System.Drawing.Size(180, 22);
            this.miXMLSer_Deser.Text = "De-serialize";
            this.miXMLSer_Deser.Click += new System.EventHandler(this.miXMLSer_Deser_Click_2);
            // 
            // miTextFile
            // 
            this.miTextFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTextFile_Export});
            this.miTextFile.Name = "miTextFile";
            this.miTextFile.Size = new System.Drawing.Size(61, 20);
            this.miTextFile.Text = "Text File";
            // 
            // miTextFile_Export
            // 
            this.miTextFile_Export.Name = "miTextFile_Export";
            this.miTextFile_Export.Size = new System.Drawing.Size(108, 22);
            this.miTextFile_Export.Text = "Export";
            this.miTextFile_Export.Click += new System.EventHandler(this.miTextFile_Export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinAppProgramming Run";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvParticipants;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miBinarySerialization;
        private System.Windows.Forms.ToolStripMenuItem miBinSer_Ser;
        private System.Windows.Forms.ToolStripMenuItem miBinSer_Deser;
        private System.Windows.Forms.ToolStripMenuItem miXMLSerialization;
        private System.Windows.Forms.ToolStripMenuItem miXMLSer_Ser;
        private System.Windows.Forms.ToolStripMenuItem miXMLSer_Deser;
        private System.Windows.Forms.ToolStripMenuItem miTextFile;
        private System.Windows.Forms.ToolStripMenuItem miTextFile_Export;
    }
}

