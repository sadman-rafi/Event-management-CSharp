namespace EMS_P
{
    partial class CEO_LOGIN
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
            this.btnLogInCEOLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassCEOlogIn = new System.Windows.Forms.Label();
            this.lblUsernameCEOlogin = new System.Windows.Forms.Label();
            this.btnBackCEOlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogInCEOLogin);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblPassCEOlogIn);
            this.panel1.Controls.Add(this.lblUsernameCEOlogin);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(479, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 283);
            this.panel1.TabIndex = 0;
            // 
            // btnLogInCEOLogin
            // 
            this.btnLogInCEOLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogInCEOLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogInCEOLogin.Location = new System.Drawing.Point(103, 230);
            this.btnLogInCEOLogin.Name = "btnLogInCEOLogin";
            this.btnLogInCEOLogin.Size = new System.Drawing.Size(84, 36);
            this.btnLogInCEOLogin.TabIndex = 4;
            this.btnLogInCEOLogin.Text = "Log In";
            this.btnLogInCEOLogin.UseVisualStyleBackColor = false;
            this.btnLogInCEOLogin.Click += new System.EventHandler(this.btnLogInCEOLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 172);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 40);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 40);
            this.textBox1.TabIndex = 2;
            // 
            // lblPassCEOlogIn
            // 
            this.lblPassCEOlogIn.AutoSize = true;
            this.lblPassCEOlogIn.Location = new System.Drawing.Point(98, 144);
            this.lblPassCEOlogIn.Name = "lblPassCEOlogIn";
            this.lblPassCEOlogIn.Size = new System.Drawing.Size(106, 25);
            this.lblPassCEOlogIn.TabIndex = 1;
            this.lblPassCEOlogIn.Text = "Password";
            // 
            // lblUsernameCEOlogin
            // 
            this.lblUsernameCEOlogin.AutoSize = true;
            this.lblUsernameCEOlogin.Location = new System.Drawing.Point(94, 63);
            this.lblUsernameCEOlogin.Name = "lblUsernameCEOlogin";
            this.lblUsernameCEOlogin.Size = new System.Drawing.Size(110, 25);
            this.lblUsernameCEOlogin.TabIndex = 0;
            this.lblUsernameCEOlogin.Text = "Username";
            // 
            // btnBackCEOlogin
            // 
            this.btnBackCEOlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBackCEOlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCEOlogin.Location = new System.Drawing.Point(0, 580);
            this.btnBackCEOlogin.Name = "btnBackCEOlogin";
            this.btnBackCEOlogin.Size = new System.Drawing.Size(84, 36);
            this.btnBackCEOlogin.TabIndex = 5;
            this.btnBackCEOlogin.Text = "Back";
            this.btnBackCEOlogin.UseVisualStyleBackColor = false;
            this.btnBackCEOlogin.Click += new System.EventHandler(this.btnBackCEOlogin_Click);
            // 
            // CEO_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.background_executive_management_sml_min_1255x700;
            this.ClientSize = new System.Drawing.Size(1206, 614);
            this.Controls.Add(this.btnBackCEOlogin);
            this.Controls.Add(this.panel1);
            this.Name = "CEO_LOGIN";
            this.Text = "CEO_LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogInCEOLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassCEOlogIn;
        private System.Windows.Forms.Label lblUsernameCEOlogin;
        private System.Windows.Forms.Button btnBackCEOlogin;
    }
}