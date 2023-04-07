namespace EMS_P
{
    partial class Customer_Login
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
            this.btnLoginCustomerLogin = new System.Windows.Forms.Button();
            this.btnBackCustomerLogin = new System.Windows.Forms.Button();
            this.txtUsernameCustomerLogin = new System.Windows.Forms.TextBox();
            this.txtPassCustomerlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassCustomerlogin);
            this.panel1.Controls.Add(this.txtUsernameCustomerLogin);
            this.panel1.Controls.Add(this.btnLoginCustomerLogin);
            this.panel1.Location = new System.Drawing.Point(492, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 286);
            this.panel1.TabIndex = 0;
            // 
            // btnLoginCustomerLogin
            // 
            this.btnLoginCustomerLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoginCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCustomerLogin.Location = new System.Drawing.Point(104, 231);
            this.btnLoginCustomerLogin.Name = "btnLoginCustomerLogin";
            this.btnLoginCustomerLogin.Size = new System.Drawing.Size(90, 35);
            this.btnLoginCustomerLogin.TabIndex = 0;
            this.btnLoginCustomerLogin.Text = "Log In";
            this.btnLoginCustomerLogin.UseVisualStyleBackColor = false;
            this.btnLoginCustomerLogin.Click += new System.EventHandler(this.btnLoginCustomerLogin_Click);
            // 
            // btnBackCustomerLogin
            // 
            this.btnBackCustomerLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCustomerLogin.Location = new System.Drawing.Point(12, 614);
            this.btnBackCustomerLogin.Name = "btnBackCustomerLogin";
            this.btnBackCustomerLogin.Size = new System.Drawing.Size(90, 35);
            this.btnBackCustomerLogin.TabIndex = 1;
            this.btnBackCustomerLogin.Text = "Back";
            this.btnBackCustomerLogin.UseVisualStyleBackColor = false;
            this.btnBackCustomerLogin.Click += new System.EventHandler(this.btnBackCustomerLogin_Click);
            // 
            // txtUsernameCustomerLogin
            // 
            this.txtUsernameCustomerLogin.Location = new System.Drawing.Point(76, 86);
            this.txtUsernameCustomerLogin.Multiline = true;
            this.txtUsernameCustomerLogin.Name = "txtUsernameCustomerLogin";
            this.txtUsernameCustomerLogin.Size = new System.Drawing.Size(156, 34);
            this.txtUsernameCustomerLogin.TabIndex = 1;
            // 
            // txtPassCustomerlogin
            // 
            this.txtPassCustomerlogin.Location = new System.Drawing.Point(76, 176);
            this.txtPassCustomerlogin.Multiline = true;
            this.txtPassCustomerlogin.Name = "txtPassCustomerlogin";
            this.txtPassCustomerlogin.Size = new System.Drawing.Size(156, 34);
            this.txtPassCustomerlogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources._60327636_pastel_watercolor_background_digital_art_painting_1;
            this.ClientSize = new System.Drawing.Size(1219, 652);
            this.Controls.Add(this.btnBackCustomerLogin);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Login";
            this.Text = "Customer_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassCustomerlogin;
        private System.Windows.Forms.TextBox txtUsernameCustomerLogin;
        private System.Windows.Forms.Button btnLoginCustomerLogin;
        private System.Windows.Forms.Button btnBackCustomerLogin;
    }
}