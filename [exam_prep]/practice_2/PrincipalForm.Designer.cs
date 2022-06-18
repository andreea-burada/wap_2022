namespace practice_2
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
            this.lviewCars = new System.Windows.Forms.ListView();
            this.lviewComponents = new System.Windows.Forms.ListView();
            this.lbCars = new System.Windows.Forms.Label();
            this.lbComponents = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lviewCars
            // 
            this.lviewCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lviewCars.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lviewCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewCars.HideSelection = false;
            this.lviewCars.Location = new System.Drawing.Point(52, 135);
            this.lviewCars.Name = "lviewCars";
            this.lviewCars.Size = new System.Drawing.Size(461, 516);
            this.lviewCars.TabIndex = 0;
            this.lviewCars.UseCompatibleStateImageBehavior = false;
            this.lviewCars.Click += new System.EventHandler(this.lviewCars_Click);
            // 
            // lviewComponents
            // 
            this.lviewComponents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviewComponents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lviewComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewComponents.HideSelection = false;
            this.lviewComponents.Location = new System.Drawing.Point(543, 135);
            this.lviewComponents.Name = "lviewComponents";
            this.lviewComponents.Size = new System.Drawing.Size(478, 516);
            this.lviewComponents.TabIndex = 1;
            this.lviewComponents.UseCompatibleStateImageBehavior = false;
            // 
            // lbCars
            // 
            this.lbCars.AutoSize = true;
            this.lbCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCars.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbCars.Location = new System.Drawing.Point(48, 108);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(52, 24);
            this.lbCars.TabIndex = 2;
            this.lbCars.Text = "Cars";
            // 
            // lbComponents
            // 
            this.lbComponents.AutoSize = true;
            this.lbComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComponents.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbComponents.Location = new System.Drawing.Point(539, 108);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(128, 24);
            this.lbComponents.TabIndex = 3;
            this.lbComponents.Text = "Components";
            // 
            // btnSort
            // 
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSort.Location = new System.Drawing.Point(870, 668);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(151, 27);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort by Weight";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1070, 707);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbComponents);
            this.Controls.Add(this.lbCars);
            this.Controls.Add(this.lviewComponents);
            this.Controls.Add(this.lviewCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars & Components Form";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrincipalForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviewCars;
        private System.Windows.Forms.ListView lviewComponents;
        private System.Windows.Forms.Label lbCars;
        private System.Windows.Forms.Label lbComponents;
        private System.Windows.Forms.Button btnSort;
    }
}

