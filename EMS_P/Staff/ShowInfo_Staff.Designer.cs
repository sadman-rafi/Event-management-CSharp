namespace EMS_P
{
    partial class ShowInfo_Staff
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
            this.lblIDshowIntoStaff = new System.Windows.Forms.Label();
            this.lblNameShowStaff = new System.Windows.Forms.Label();
            this.lblDateOfBirthStaff = new System.Windows.Forms.Label();
            this.lblDepartmentStaffShow = new System.Windows.Forms.Label();
            this.btnBackShowStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDshowIntoStaff
            // 
            this.lblIDshowIntoStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblIDshowIntoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDshowIntoStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDshowIntoStaff.Location = new System.Drawing.Point(174, 150);
            this.lblIDshowIntoStaff.Name = "lblIDshowIntoStaff";
            this.lblIDshowIntoStaff.Size = new System.Drawing.Size(100, 23);
            this.lblIDshowIntoStaff.TabIndex = 0;
            this.lblIDshowIntoStaff.Text = "ID:";
            // 
            // lblNameShowStaff
            // 
            this.lblNameShowStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblNameShowStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameShowStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameShowStaff.Location = new System.Drawing.Point(174, 234);
            this.lblNameShowStaff.Name = "lblNameShowStaff";
            this.lblNameShowStaff.Size = new System.Drawing.Size(100, 23);
            this.lblNameShowStaff.TabIndex = 1;
            this.lblNameShowStaff.Text = "Name:";
            // 
            // lblDateOfBirthStaff
            // 
            this.lblDateOfBirthStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirthStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateOfBirthStaff.Location = new System.Drawing.Point(174, 295);
            this.lblDateOfBirthStaff.Name = "lblDateOfBirthStaff";
            this.lblDateOfBirthStaff.Size = new System.Drawing.Size(151, 23);
            this.lblDateOfBirthStaff.TabIndex = 2;
            this.lblDateOfBirthStaff.Text = "Date of Birth:";
            // 
            // lblDepartmentStaffShow
            // 
            this.lblDepartmentStaffShow.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentStaffShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentStaffShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentStaffShow.Location = new System.Drawing.Point(174, 358);
            this.lblDepartmentStaffShow.Name = "lblDepartmentStaffShow";
            this.lblDepartmentStaffShow.Size = new System.Drawing.Size(151, 23);
            this.lblDepartmentStaffShow.TabIndex = 3;
            this.lblDepartmentStaffShow.Text = "Department:";
            // 
            // btnBackShowStaff
            // 
            this.btnBackShowStaff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackShowStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackShowStaff.Location = new System.Drawing.Point(13, 594);
            this.btnBackShowStaff.Name = "btnBackShowStaff";
            this.btnBackShowStaff.Size = new System.Drawing.Size(86, 29);
            this.btnBackShowStaff.TabIndex = 4;
            this.btnBackShowStaff.Text = "Back";
            this.btnBackShowStaff.UseVisualStyleBackColor = false;
            this.btnBackShowStaff.Click += new System.EventHandler(this.btnBackShowStaff_Click);
            // 
            // ShowInfo_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(871, 635);
            this.Controls.Add(this.btnBackShowStaff);
            this.Controls.Add(this.lblDepartmentStaffShow);
            this.Controls.Add(this.lblDateOfBirthStaff);
            this.Controls.Add(this.lblNameShowStaff);
            this.Controls.Add(this.lblIDshowIntoStaff);
            this.Name = "ShowInfo_Staff";
            this.Text = "ShowInfo_Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIDshowIntoStaff;
        private System.Windows.Forms.Label lblNameShowStaff;
        private System.Windows.Forms.Label lblDateOfBirthStaff;
        private System.Windows.Forms.Label lblDepartmentStaffShow;
        private System.Windows.Forms.Button btnBackShowStaff;
    }
}