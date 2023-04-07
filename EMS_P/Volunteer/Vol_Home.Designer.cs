namespace EMS_P
{
    partial class Vol_Home
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
            this.btnDetailsVol_Home = new System.Windows.Forms.Button();
            this.btnlogoutVol_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetailsVol_Home
            // 
            this.btnDetailsVol_Home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetailsVol_Home.Location = new System.Drawing.Point(387, 201);
            this.btnDetailsVol_Home.Name = "btnDetailsVol_Home";
            this.btnDetailsVol_Home.Size = new System.Drawing.Size(189, 107);
            this.btnDetailsVol_Home.TabIndex = 0;
            this.btnDetailsVol_Home.Text = "Details";
            this.btnDetailsVol_Home.UseVisualStyleBackColor = false;
            // 
            // btnlogoutVol_Home
            // 
            this.btnlogoutVol_Home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogoutVol_Home.Location = new System.Drawing.Point(27, 557);
            this.btnlogoutVol_Home.Name = "btnlogoutVol_Home";
            this.btnlogoutVol_Home.Size = new System.Drawing.Size(85, 40);
            this.btnlogoutVol_Home.TabIndex = 1;
            this.btnlogoutVol_Home.Text = "logout";
            this.btnlogoutVol_Home.UseVisualStyleBackColor = false;
            this.btnlogoutVol_Home.Click += new System.EventHandler(this.btnlogoutVol_Home_Click);
            // 
            // Vol_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 609);
            this.Controls.Add(this.btnlogoutVol_Home);
            this.Controls.Add(this.btnDetailsVol_Home);
            this.Name = "Vol_Home";
            this.Text = "Vol_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetailsVol_Home;
        private System.Windows.Forms.Button btnlogoutVol_Home;
    }
}