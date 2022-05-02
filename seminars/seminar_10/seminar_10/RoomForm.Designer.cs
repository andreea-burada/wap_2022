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
            this.checkHasProjector = new System.Windows.Forms.CheckBox();
            this.roomIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // checkHasProjector
            // 
            this.checkHasProjector.AutoSize = true;
            this.checkHasProjector.Location = new System.Drawing.Point(68, 129);
            this.checkHasProjector.Name = "checkHasProjector";
            this.checkHasProjector.Size = new System.Drawing.Size(111, 20);
            this.checkHasProjector.TabIndex = 0;
            this.checkHasProjector.Text = "Has Projector";
            this.checkHasProjector.UseVisualStyleBackColor = true;
            // 
            // roomIdUpDown
            // 
            this.roomIdUpDown.Location = new System.Drawing.Point(122, 43);
            this.roomIdUpDown.Name = "roomIdUpDown";
            this.roomIdUpDown.Size = new System.Drawing.Size(321, 22);
            this.roomIdUpDown.TabIndex = 1;
            this.roomIdUpDown.Tag = "";
            this.roomIdUpDown.ValueChanged += new System.EventHandler(this.roomIdUpDown_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(68, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTextBox.Location = new System.Drawing.Point(68, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(48, 22);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Name";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.enterNameTextBox.Location = new System.Drawing.Point(122, 85);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(303, 22);
            this.enterNameTextBox.TabIndex = 4;
            this.enterNameTextBox.Text = "(Enter the name here)";
            this.enterNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(412, 263);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(97, 36);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(309, 263);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 36);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 311);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.roomIdUpDown);
            this.Controls.Add(this.checkHasProjector);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomIdUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkHasProjector;
        private System.Windows.Forms.NumericUpDown roomIdUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button submitButton;
    }
}