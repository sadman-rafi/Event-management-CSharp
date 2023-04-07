namespace EMS_P
{
    partial class Contact_Us
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
            this.btnBackContactUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(148, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1242, 819);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Us.\r\n\r\nPhone number: 017*********\r\n\r\nWhatsapp: 017*********\r\n\r\nEmail: trt" +
    "n@gmail.com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBackContactUs
            // 
            this.btnBackContactUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackContactUs.Location = new System.Drawing.Point(24, 600);
            this.btnBackContactUs.Name = "btnBackContactUs";
            this.btnBackContactUs.Size = new System.Drawing.Size(89, 36);
            this.btnBackContactUs.TabIndex = 1;
            this.btnBackContactUs.Text = "Back";
            this.btnBackContactUs.UseVisualStyleBackColor = false;
            this.btnBackContactUs.Click += new System.EventHandler(this.btnBackContactUs_Click);
            // 
            // Contact_Us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.istockphoto_1049658692_612x612_1255x700;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnBackContactUs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Contact_Us";
            this.Text = "Contact_Us";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackContactUs;
    }
}