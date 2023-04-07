namespace EMS_P
{
    partial class Responsibility
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackResponsibilityStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Work";
            // 
            // btnBackResponsibilityStaff
            // 
            this.btnBackResponsibilityStaff.Location = new System.Drawing.Point(41, 511);
            this.btnBackResponsibilityStaff.Name = "btnBackResponsibilityStaff";
            this.btnBackResponsibilityStaff.Size = new System.Drawing.Size(75, 40);
            this.btnBackResponsibilityStaff.TabIndex = 1;
            this.btnBackResponsibilityStaff.Text = "Back";
            this.btnBackResponsibilityStaff.UseVisualStyleBackColor = true;
            this.btnBackResponsibilityStaff.Click += new System.EventHandler(this.btnBackResponsibilityStaff_Click);
            // 
            // Responsibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 563);
            this.Controls.Add(this.btnBackResponsibilityStaff);
            this.Controls.Add(this.label1);
            this.Name = "Responsibility";
            this.Text = "Responsibility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackResponsibilityStaff;
    }
}