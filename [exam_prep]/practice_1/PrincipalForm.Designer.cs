namespace practice_1
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lvDoctors = new System.Windows.Forms.ListView();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripXMLExport = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrint = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrintPreview = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPageSetup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBarChart = new System.Windows.Forms.ToolStripLabel();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortBirthdate = new System.Windows.Forms.Button();
            this.btnSortDefault = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(20, 51);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(131, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Doctors List";
            // 
            // lvDoctors
            // 
            this.lvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDoctors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDoctors.HideSelection = false;
            this.lvDoctors.Location = new System.Drawing.Point(24, 87);
            this.lvDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.Size = new System.Drawing.Size(756, 405);
            this.lvDoctors.TabIndex = 1;
            this.lvDoctors.UseCompatibleStateImageBehavior = false;
            this.lvDoctors.DoubleClick += new System.EventHandler(this.lvDoctors_DoubleClick);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEdit.Location = new System.Drawing.Point(688, 505);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(92, 44);
            this.btnAddEdit.TabIndex = 2;
            this.btnAddEdit.Text = "Add/Edit";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.Location = new System.Drawing.Point(26, 505);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripXMLExport,
            this.toolStripSeparator1,
            this.toolStripPrint,
            this.toolStripSeparator2,
            this.toolStripPrintPreview,
            this.toolStripSeparator3,
            this.toolStripPageSetup,
            this.toolStripSeparator4,
            this.toolStripBarChart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripXMLExport
            // 
            this.toolStripXMLExport.Name = "toolStripXMLExport";
            this.toolStripXMLExport.Size = new System.Drawing.Size(89, 22);
            this.toolStripXMLExport.Text = "XML Export";
            this.toolStripXMLExport.Click += new System.EventHandler(this.toolStripXMLExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(40, 22);
            this.toolStripPrint.Text = "Print";
            this.toolStripPrint.Click += new System.EventHandler(this.toolStripPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPrintPreview
            // 
            this.toolStripPrintPreview.Name = "toolStripPrintPreview";
            this.toolStripPrintPreview.Size = new System.Drawing.Size(105, 22);
            this.toolStripPrintPreview.Text = "Print Preview";
            this.toolStripPrintPreview.Click += new System.EventHandler(this.toolStripPrintPreview_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPageSetup
            // 
            this.toolStripPageSetup.Name = "toolStripPageSetup";
            this.toolStripPageSetup.Size = new System.Drawing.Size(93, 22);
            this.toolStripPageSetup.Text = "Page Setup";
            this.toolStripPageSetup.Click += new System.EventHandler(this.toolStripPageSetup_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBarChart
            // 
            this.toolStripBarChart.Name = "toolStripBarChart";
            this.toolStripBarChart.Size = new System.Drawing.Size(78, 22);
            this.toolStripBarChart.Text = "Bar Chart";
            this.toolStripBarChart.Click += new System.EventHandler(this.toolStripBarChart_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.ForeColor = System.Drawing.Color.Crimson;
            this.btnSortName.Location = new System.Drawing.Point(513, 51);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(118, 32);
            this.btnSortName.TabIndex = 5;
            this.btnSortName.Text = "Sort by Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortBirthdate
            // 
            this.btnSortBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortBirthdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortBirthdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortBirthdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnSortBirthdate.Location = new System.Drawing.Point(635, 51);
            this.btnSortBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortBirthdate.Name = "btnSortBirthdate";
            this.btnSortBirthdate.Size = new System.Drawing.Size(145, 32);
            this.btnSortBirthdate.TabIndex = 6;
            this.btnSortBirthdate.Text = "Sort by Birthdate";
            this.btnSortBirthdate.UseVisualStyleBackColor = true;
            this.btnSortBirthdate.Click += new System.EventHandler(this.btnSortBirthdate_Click);
            // 
            // btnSortDefault
            // 
            this.btnSortDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortDefault.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDefault.ForeColor = System.Drawing.Color.Crimson;
            this.btnSortDefault.Location = new System.Drawing.Point(368, 51);
            this.btnSortDefault.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortDefault.Name = "btnSortDefault";
            this.btnSortDefault.Size = new System.Drawing.Size(141, 32);
            this.btnSortDefault.TabIndex = 7;
            this.btnSortDefault.Text = "Sort Default (by Id)";
            this.btnSortDefault.UseVisualStyleBackColor = true;
            this.btnSortDefault.Click += new System.EventHandler(this.btnSortDefault_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 559);
            this.Controls.Add(this.btnSortDefault);
            this.Controls.Add(this.btnSortBirthdate);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.lvDoctors);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripXMLExport;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortBirthdate;
        private System.Windows.Forms.Button btnSortDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripPageSetup;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripBarChart;
    }
}

