namespace practice_1
{
    partial class DoctorForm
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lboxSpecialty = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbWage = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSpecialty = new System.Windows.Forms.Label();
            this.errorpDoctor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorpDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(59, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(267, 30);
            this.tbName.TabIndex = 0;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbWage
            // 
            this.tbWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWage.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWage.Location = new System.Drawing.Point(59, 353);
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(267, 30);
            this.tbWage.TabIndex = 2;
            this.tbWage.Validating += new System.ComponentModel.CancelEventHandler(this.tbWage_Validating);
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBirthDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(59, 233);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(267, 32);
            this.dtpBirthDay.TabIndex = 1;
            this.dtpBirthDay.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthDay_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(54, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(191, 27);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Add/Edit Doctor";
            // 
            // lboxSpecialty
            // 
            this.lboxSpecialty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lboxSpecialty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxSpecialty.FormattingEnabled = true;
            this.lboxSpecialty.ItemHeight = 21;
            this.lboxSpecialty.Location = new System.Drawing.Point(409, 127);
            this.lboxSpecialty.Name = "lboxSpecialty";
            this.lboxSpecialty.Size = new System.Drawing.Size(315, 256);
            this.lboxSpecialty.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(55, 96);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 21);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(55, 209);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(83, 21);
            this.lbBirthday.TabIndex = 6;
            this.lbBirthday.Text = "Birth Day";
            // 
            // lbWage
            // 
            this.lbWage.AutoSize = true;
            this.lbWage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWage.Location = new System.Drawing.Point(55, 329);
            this.lbWage.Name = "lbWage";
            this.lbWage.Size = new System.Drawing.Size(61, 21);
            this.lbWage.TabIndex = 7;
            this.lbWage.Text = "Wage";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAccept.Location = new System.Drawing.Point(634, 404);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 46);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(59, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbSpecialty
            // 
            this.lbSpecialty.AutoSize = true;
            this.lbSpecialty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecialty.Location = new System.Drawing.Point(405, 96);
            this.lbSpecialty.Name = "lbSpecialty";
            this.lbSpecialty.Size = new System.Drawing.Size(85, 21);
            this.lbSpecialty.TabIndex = 10;
            this.lbSpecialty.Text = "Specialty";
            // 
            // errorpDoctor
            // 
            this.errorpDoctor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorpDoctor.ContainerControl = this;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.lbSpecialty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbWage);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lboxSpecialty);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.tbWage);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Doctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorpDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox lboxSpecialty;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbWage;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSpecialty;
        private System.Windows.Forms.ErrorProvider errorpDoctor;
    }
}