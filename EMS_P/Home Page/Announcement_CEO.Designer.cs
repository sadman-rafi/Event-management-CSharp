namespace EMS_P
{
    partial class Announcement_CEO
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
            this.lblAnnTitle = new System.Windows.Forms.Label();
            this.lblAnnouncementMessege = new System.Windows.Forms.Label();
            this.txttitleAnn = new System.Windows.Forms.TextBox();
            this.txtMessageAnnouncement = new System.Windows.Forms.TextBox();
            this.btnBackAnnouncementCeo = new System.Windows.Forms.Button();
            this.btnAnnouncementSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnnTitle
            // 
            this.lblAnnTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnTitle.ForeColor = System.Drawing.Color.White;
            this.lblAnnTitle.Location = new System.Drawing.Point(578, 88);
            this.lblAnnTitle.Name = "lblAnnTitle";
            this.lblAnnTitle.Size = new System.Drawing.Size(131, 37);
            this.lblAnnTitle.TabIndex = 0;
            this.lblAnnTitle.Text = "Title";
            // 
            // lblAnnouncementMessege
            // 
            this.lblAnnouncementMessege.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnouncementMessege.ForeColor = System.Drawing.Color.White;
            this.lblAnnouncementMessege.Location = new System.Drawing.Point(578, 243);
            this.lblAnnouncementMessege.Name = "lblAnnouncementMessege";
            this.lblAnnouncementMessege.Size = new System.Drawing.Size(131, 37);
            this.lblAnnouncementMessege.TabIndex = 1;
            this.lblAnnouncementMessege.Text = "Message";
            // 
            // txttitleAnn
            // 
            this.txttitleAnn.Location = new System.Drawing.Point(583, 137);
            this.txttitleAnn.Multiline = true;
            this.txttitleAnn.Name = "txttitleAnn";
            this.txttitleAnn.Size = new System.Drawing.Size(594, 48);
            this.txttitleAnn.TabIndex = 2;
            // 
            // txtMessageAnnouncement
            // 
            this.txtMessageAnnouncement.Location = new System.Drawing.Point(583, 283);
            this.txtMessageAnnouncement.Multiline = true;
            this.txtMessageAnnouncement.Name = "txtMessageAnnouncement";
            this.txtMessageAnnouncement.Size = new System.Drawing.Size(594, 184);
            this.txtMessageAnnouncement.TabIndex = 3;
            // 
            // btnBackAnnouncementCeo
            // 
            this.btnBackAnnouncementCeo.BackColor = System.Drawing.Color.White;
            this.btnBackAnnouncementCeo.Location = new System.Drawing.Point(1117, 591);
            this.btnBackAnnouncementCeo.Name = "btnBackAnnouncementCeo";
            this.btnBackAnnouncementCeo.Size = new System.Drawing.Size(98, 34);
            this.btnBackAnnouncementCeo.TabIndex = 4;
            this.btnBackAnnouncementCeo.Text = "Back";
            this.btnBackAnnouncementCeo.UseVisualStyleBackColor = false;
            this.btnBackAnnouncementCeo.Click += new System.EventHandler(this.btnBackAnnouncementCeo_Click);
            // 
            // btnAnnouncementSubmit
            // 
            this.btnAnnouncementSubmit.BackColor = System.Drawing.Color.White;
            this.btnAnnouncementSubmit.Location = new System.Drawing.Point(583, 485);
            this.btnAnnouncementSubmit.Name = "btnAnnouncementSubmit";
            this.btnAnnouncementSubmit.Size = new System.Drawing.Size(98, 34);
            this.btnAnnouncementSubmit.TabIndex = 5;
            this.btnAnnouncementSubmit.Text = "Submit";
            this.btnAnnouncementSubmit.UseVisualStyleBackColor = false;
            // 
            // Announcement_CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.depositphotos_73441387_stock_photo_black_blank_blackboard_with_hand_1255x700;
            this.ClientSize = new System.Drawing.Size(1232, 637);
            this.Controls.Add(this.btnAnnouncementSubmit);
            this.Controls.Add(this.btnBackAnnouncementCeo);
            this.Controls.Add(this.txtMessageAnnouncement);
            this.Controls.Add(this.txttitleAnn);
            this.Controls.Add(this.lblAnnouncementMessege);
            this.Controls.Add(this.lblAnnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Announcement_CEO";
            this.Text = "Announcement_CEO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnTitle;
        private System.Windows.Forms.Label lblAnnouncementMessege;
        private System.Windows.Forms.TextBox txttitleAnn;
        private System.Windows.Forms.TextBox txtMessageAnnouncement;
        private System.Windows.Forms.Button btnBackAnnouncementCeo;
        private System.Windows.Forms.Button btnAnnouncementSubmit;
    }
}