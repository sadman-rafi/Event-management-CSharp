namespace EMS_P
{
    partial class Staff_Home
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
            this.btnShowDealails = new System.Windows.Forms.Button();
            this.btnResponsibility = new System.Windows.Forms.Button();
            this.btnSalaryInfoStaff = new System.Windows.Forms.Button();
            this.btnLogoutStaffhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowDealails
            // 
            this.btnShowDealails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShowDealails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDealails.Location = new System.Drawing.Point(288, 184);
            this.btnShowDealails.Name = "btnShowDealails";
            this.btnShowDealails.Size = new System.Drawing.Size(173, 58);
            this.btnShowDealails.TabIndex = 0;
            this.btnShowDealails.Text = "Show Deatils";
            this.btnShowDealails.UseVisualStyleBackColor = false;
            this.btnShowDealails.Click += new System.EventHandler(this.btnShowDealails_Click);
            // 
            // btnResponsibility
            // 
            this.btnResponsibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResponsibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponsibility.Location = new System.Drawing.Point(587, 184);
            this.btnResponsibility.Name = "btnResponsibility";
            this.btnResponsibility.Size = new System.Drawing.Size(173, 58);
            this.btnResponsibility.TabIndex = 1;
            this.btnResponsibility.Text = "Responsibility";
            this.btnResponsibility.UseVisualStyleBackColor = false;
            this.btnResponsibility.Click += new System.EventHandler(this.btnResponsibility_Click);
            // 
            // btnSalaryInfoStaff
            // 
            this.btnSalaryInfoStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalaryInfoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryInfoStaff.Location = new System.Drawing.Point(444, 307);
            this.btnSalaryInfoStaff.Name = "btnSalaryInfoStaff";
            this.btnSalaryInfoStaff.Size = new System.Drawing.Size(173, 58);
            this.btnSalaryInfoStaff.TabIndex = 2;
            this.btnSalaryInfoStaff.Text = "Salary Info";
            this.btnSalaryInfoStaff.UseVisualStyleBackColor = false;
            this.btnSalaryInfoStaff.Click += new System.EventHandler(this.btnSalaryInfoStaff_Click);
            // 
            // btnLogoutStaffhome
            // 
            this.btnLogoutStaffhome.BackColor = System.Drawing.Color.Red;
            this.btnLogoutStaffhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutStaffhome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutStaffhome.Location = new System.Drawing.Point(23, 581);
            this.btnLogoutStaffhome.Name = "btnLogoutStaffhome";
            this.btnLogoutStaffhome.Size = new System.Drawing.Size(100, 45);
            this.btnLogoutStaffhome.TabIndex = 3;
            this.btnLogoutStaffhome.Text = "Logout";
            this.btnLogoutStaffhome.UseVisualStyleBackColor = false;
            this.btnLogoutStaffhome.Click += new System.EventHandler(this.btnLogoutStaffhome_Click);
            // 
            // Staff_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 638);
            this.Controls.Add(this.btnLogoutStaffhome);
            this.Controls.Add(this.btnSalaryInfoStaff);
            this.Controls.Add(this.btnResponsibility);
            this.Controls.Add(this.btnShowDealails);
            this.Name = "Staff_Home";
            this.Text = "Staff_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDealails;
        private System.Windows.Forms.Button btnResponsibility;
        private System.Windows.Forms.Button btnSalaryInfoStaff;
        private System.Windows.Forms.Button btnLogoutStaffhome;
    }
}