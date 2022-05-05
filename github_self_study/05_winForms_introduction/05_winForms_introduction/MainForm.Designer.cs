namespace _05_winForms_introduction
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
            this.tbNumericTextBox = new System.Windows.Forms.TextBox();
            this.tbDisplayText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNumericTextBox
            // 
            this.tbNumericTextBox.Location = new System.Drawing.Point(106, 106);
            this.tbNumericTextBox.Name = "tbNumericTextBox";
            this.tbNumericTextBox.Size = new System.Drawing.Size(222, 20);
            this.tbNumericTextBox.TabIndex = 0;
            this.tbNumericTextBox.TextChanged += new System.EventHandler(this.tbNumericTextBox_TextChanged);
            this.tbNumericTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumericTextBox_KeyPress);
            // 
            // tbDisplayText
            // 
            this.tbDisplayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayText.Location = new System.Drawing.Point(106, 80);
            this.tbDisplayText.Margin = new System.Windows.Forms.Padding(0);
            this.tbDisplayText.Name = "tbDisplayText";
            this.tbDisplayText.ReadOnly = true;
            this.tbDisplayText.Size = new System.Drawing.Size(222, 22);
            this.tbDisplayText.TabIndex = 1;
            this.tbDisplayText.Text = "Enter a number:";
            this.tbDisplayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 245);
            this.Controls.Add(this.tbDisplayText);
            this.Controls.Add(this.tbNumericTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumericTextBox;
        private System.Windows.Forms.TextBox tbDisplayText;
    }
}

