namespace EMS_P
{
    partial class VOL_login
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
            this.lblUsernameVolLogin = new System.Windows.Forms.Label();
            this.lblPassVolLogin = new System.Windows.Forms.Label();
            this.txtUsernameVolLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordVolLogin = new System.Windows.Forms.TextBox();
            this.btnBackVolLogIn = new System.Windows.Forms.Button();
            this.btnLoginVolLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnLoginVolLogin);
            this.panel1.Controls.Add(this.txtPasswordVolLogin);
            this.panel1.Controls.Add(this.txtUsernameVolLogin);
            this.panel1.Controls.Add(this.lblPassVolLogin);
            this.panel1.Controls.Add(this.lblUsernameVolLogin);
            this.panel1.Location = new System.Drawing.Point(456, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 248);
            this.panel1.TabIndex = 0;
            // 
            // lblUsernameVolLogin
            // 
            this.lblUsernameVolLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameVolLogin.Location = new System.Drawing.Point(84, 47);
            this.lblUsernameVolLogin.Name = "lblUsernameVolLogin";
            this.lblUsernameVolLogin.Size = new System.Drawing.Size(100, 23);
            this.lblUsernameVolLogin.TabIndex = 0;
            this.lblUsernameVolLogin.Text = "Username";
            // 
            // lblPassVolLogin
            // 
            this.lblPassVolLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassVolLogin.Location = new System.Drawing.Point(84, 125);
            this.lblPassVolLogin.Name = "lblPassVolLogin";
            this.lblPassVolLogin.Size = new System.Drawing.Size(100, 23);
            this.lblPassVolLogin.TabIndex = 1;
            this.lblPassVolLogin.Text = "Password";
            // 
            // txtUsernameVolLogin
            // 
            this.txtUsernameVolLogin.Location = new System.Drawing.Point(45, 73);
            this.txtUsernameVolLogin.Multiline = true;
            this.txtUsernameVolLogin.Name = "txtUsernameVolLogin";
            this.txtUsernameVolLogin.Size = new System.Drawing.Size(186, 35);
            this.txtUsernameVolLogin.TabIndex = 2;
            // 
            // txtPasswordVolLogin
            // 
            this.txtPasswordVolLogin.Location = new System.Drawing.Point(45, 151);
            this.txtPasswordVolLogin.Multiline = true;
            this.txtPasswordVolLogin.Name = "txtPasswordVolLogin";
            this.txtPasswordVolLogin.Size = new System.Drawing.Size(186, 35);
            this.txtPasswordVolLogin.TabIndex = 3;
            // 
            // btnBackVolLogIn
            // 
            this.btnBackVolLogIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackVolLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackVolLogIn.Location = new System.Drawing.Point(23, 560);
            this.btnBackVolLogIn.Name = "btnBackVolLogIn";
            this.btnBackVolLogIn.Size = new System.Drawing.Size(99, 42);
            this.btnBackVolLogIn.TabIndex = 1;
            this.btnBackVolLogIn.Text = "Back";
            this.btnBackVolLogIn.UseVisualStyleBackColor = false;
            this.btnBackVolLogIn.Click += new System.EventHandler(this.btnBackVolLogIn_Click);
            // 
            // btnLoginVolLogin
            // 
            this.btnLoginVolLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginVolLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginVolLogin.Location = new System.Drawing.Point(85, 205);
            this.btnLoginVolLogin.Name = "btnLoginVolLogin";
            this.btnLoginVolLogin.Size = new System.Drawing.Size(99, 28);
            this.btnLoginVolLogin.TabIndex = 2;
            this.btnLoginVolLogin.Text = "Login";
            this.btnLoginVolLogin.UseVisualStyleBackColor = false;
            this.btnLoginVolLogin.Click += new System.EventHandler(this.btnLoginVolLogin_Click);
            // 
            // VOL_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 614);
            this.Controls.Add(this.btnBackVolLogIn);
            this.Controls.Add(this.panel1);
            this.Name = "VOL_login";
            this.Text = "VOL_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginVolLogin;
        private System.Windows.Forms.TextBox txtPasswordVolLogin;
        private System.Windows.Forms.TextBox txtUsernameVolLogin;
        private System.Windows.Forms.Label lblPassVolLogin;
        private System.Windows.Forms.Label lblUsernameVolLogin;
        private System.Windows.Forms.Button btnBackVolLogIn;
    }
}