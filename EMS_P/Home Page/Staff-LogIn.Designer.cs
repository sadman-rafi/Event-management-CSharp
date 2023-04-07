namespace EMS_P
{
    partial class Staff_LogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogInStafflogin = new System.Windows.Forms.Button();
            this.txtPasswordStaffLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameStafflogin = new System.Windows.Forms.TextBox();
            this.lblPasswordStafflogin = new System.Windows.Forms.Label();
            this.lblUsernameStafflogin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.btnLogInStafflogin);
            this.panel1.Controls.Add(this.txtPasswordStaffLogin);
            this.panel1.Controls.Add(this.txtUsernameStafflogin);
            this.panel1.Controls.Add(this.lblPasswordStafflogin);
            this.panel1.Controls.Add(this.lblUsernameStafflogin);
            this.panel1.Location = new System.Drawing.Point(500, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnLogInStafflogin
            // 
            this.btnLogInStafflogin.BackColor = System.Drawing.Color.White;
            this.btnLogInStafflogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInStafflogin.Location = new System.Drawing.Point(84, 202);
            this.btnLogInStafflogin.Name = "btnLogInStafflogin";
            this.btnLogInStafflogin.Size = new System.Drawing.Size(83, 34);
            this.btnLogInStafflogin.TabIndex = 4;
            this.btnLogInStafflogin.Text = "Log In";
            this.btnLogInStafflogin.UseVisualStyleBackColor = false;
            this.btnLogInStafflogin.Click += new System.EventHandler(this.btnLogInStafflogin_Click);
            // 
            // txtPasswordStaffLogin
            // 
            this.txtPasswordStaffLogin.Location = new System.Drawing.Point(51, 152);
            this.txtPasswordStaffLogin.Multiline = true;
            this.txtPasswordStaffLogin.Name = "txtPasswordStaffLogin";
            this.txtPasswordStaffLogin.Size = new System.Drawing.Size(163, 44);
            this.txtPasswordStaffLogin.TabIndex = 3;
            // 
            // txtUsernameStafflogin
            // 
            this.txtUsernameStafflogin.Location = new System.Drawing.Point(51, 77);
            this.txtUsernameStafflogin.Multiline = true;
            this.txtUsernameStafflogin.Name = "txtUsernameStafflogin";
            this.txtUsernameStafflogin.Size = new System.Drawing.Size(163, 44);
            this.txtUsernameStafflogin.TabIndex = 2;
            // 
            // lblPasswordStafflogin
            // 
            this.lblPasswordStafflogin.AutoSize = true;
            this.lblPasswordStafflogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStafflogin.Location = new System.Drawing.Point(79, 124);
            this.lblPasswordStafflogin.Name = "lblPasswordStafflogin";
            this.lblPasswordStafflogin.Size = new System.Drawing.Size(104, 25);
            this.lblPasswordStafflogin.TabIndex = 1;
            this.lblPasswordStafflogin.Text = "password";
            // 
            // lblUsernameStafflogin
            // 
            this.lblUsernameStafflogin.AutoSize = true;
            this.lblUsernameStafflogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameStafflogin.Location = new System.Drawing.Point(79, 34);
            this.lblUsernameStafflogin.Name = "lblUsernameStafflogin";
            this.lblUsernameStafflogin.Size = new System.Drawing.Size(110, 25);
            this.lblUsernameStafflogin.TabIndex = 0;
            this.lblUsernameStafflogin.Text = "Username";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 585);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Staff_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.aed449f3fce390371328c489b93028a6_1255x700;
            this.ClientSize = new System.Drawing.Size(1197, 634);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Staff_LogIn";
            this.Text = "Staff_LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogInStafflogin;
        private System.Windows.Forms.TextBox txtPasswordStaffLogin;
        private System.Windows.Forms.TextBox txtUsernameStafflogin;
        private System.Windows.Forms.Label lblPasswordStafflogin;
        private System.Windows.Forms.Label lblUsernameStafflogin;
        private System.Windows.Forms.Button btnBack;
    }
}