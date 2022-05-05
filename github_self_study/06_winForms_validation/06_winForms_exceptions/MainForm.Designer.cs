namespace _06_winForms_exceptions
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
            this.tbDenumerator = new System.Windows.Forms.TextBox();
            this.tbNumerator = new System.Windows.Forms.TextBox();
            this.gbCalculator = new System.Windows.Forms.GroupBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDenumerator
            // 
            this.tbDenumerator.Location = new System.Drawing.Point(217, 46);
            this.tbDenumerator.Name = "tbDenumerator";
            this.tbDenumerator.Size = new System.Drawing.Size(120, 24);
            this.tbDenumerator.TabIndex = 0;
            // 
            // tbNumerator
            // 
            this.tbNumerator.Location = new System.Drawing.Point(26, 46);
            this.tbNumerator.Name = "tbNumerator";
            this.tbNumerator.Size = new System.Drawing.Size(124, 24);
            this.tbNumerator.TabIndex = 2;
            // 
            // gbCalculator
            // 
            this.gbCalculator.Controls.Add(this.lblResult);
            this.gbCalculator.Controls.Add(this.lblDivision);
            this.gbCalculator.Controls.Add(this.btnEquals);
            this.gbCalculator.Controls.Add(this.tbNumerator);
            this.gbCalculator.Controls.Add(this.tbDenumerator);
            this.gbCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalculator.Location = new System.Drawing.Point(60, 36);
            this.gbCalculator.Name = "gbCalculator";
            this.gbCalculator.Size = new System.Drawing.Size(678, 122);
            this.gbCalculator.TabIndex = 3;
            this.gbCalculator.TabStop = false;
            this.gbCalculator.Text = "Division Calculator";
            this.gbCalculator.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.LightGreen;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEquals.Location = new System.Drawing.Point(361, 42);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 31);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClear.Font = new System.Drawing.Font("JetBrainsMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(663, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(178, 49);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(12, 18);
            this.lblDivision.TabIndex = 5;
            this.lblDivision.Text = "/";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(466, 47);
            this.lblResult.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 210);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbCalculator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbCalculator.ResumeLayout(false);
            this.gbCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumerator;
        private System.Windows.Forms.TextBox tbNumerator;
        private System.Windows.Forms.GroupBox gbCalculator;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblResult;
    }
}

