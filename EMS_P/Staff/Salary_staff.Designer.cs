namespace EMS_P
{
    partial class Salary_staff
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
            this.lblIDSalaryStaff = new System.Windows.Forms.Label();
            this.lblNameSalaryStaff = new System.Windows.Forms.Label();
            this.lblSalarySalaryStaff = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDSalaryStaff
            // 
            this.lblIDSalaryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSalaryStaff.Location = new System.Drawing.Point(207, 188);
            this.lblIDSalaryStaff.Name = "lblIDSalaryStaff";
            this.lblIDSalaryStaff.Size = new System.Drawing.Size(100, 23);
            this.lblIDSalaryStaff.TabIndex = 0;
            this.lblIDSalaryStaff.Text = "ID:";
            // 
            // lblNameSalaryStaff
            // 
            this.lblNameSalaryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSalaryStaff.Location = new System.Drawing.Point(207, 273);
            this.lblNameSalaryStaff.Name = "lblNameSalaryStaff";
            this.lblNameSalaryStaff.Size = new System.Drawing.Size(100, 23);
            this.lblNameSalaryStaff.TabIndex = 1;
            this.lblNameSalaryStaff.Text = "Name:";
            // 
            // lblSalarySalaryStaff
            // 
            this.lblSalarySalaryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarySalaryStaff.Location = new System.Drawing.Point(207, 348);
            this.lblSalarySalaryStaff.Name = "lblSalarySalaryStaff";
            this.lblSalarySalaryStaff.Size = new System.Drawing.Size(100, 23);
            this.lblSalarySalaryStaff.TabIndex = 2;
            this.lblSalarySalaryStaff.Text = "Salary:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salary_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSalarySalaryStaff);
            this.Controls.Add(this.lblNameSalaryStaff);
            this.Controls.Add(this.lblIDSalaryStaff);
            this.Name = "Salary_staff";
            this.Text = "Salary_staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIDSalaryStaff;
        private System.Windows.Forms.Label lblNameSalaryStaff;
        private System.Windows.Forms.Label lblSalarySalaryStaff;
        private System.Windows.Forms.Button button1;
    }
}