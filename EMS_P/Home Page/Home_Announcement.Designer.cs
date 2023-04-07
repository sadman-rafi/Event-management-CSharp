namespace EMS_P
{
    partial class Home_Announcement
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
            this.dgvHomeAnnouncement = new System.Windows.Forms.DataGridView();
            this.btnBackHomeAnnouncement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeAnnouncement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHomeAnnouncement
            // 
            this.dgvHomeAnnouncement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeAnnouncement.Location = new System.Drawing.Point(12, 125);
            this.dgvHomeAnnouncement.Name = "dgvHomeAnnouncement";
            this.dgvHomeAnnouncement.RowTemplate.Height = 24;
            this.dgvHomeAnnouncement.Size = new System.Drawing.Size(1200, 150);
            this.dgvHomeAnnouncement.TabIndex = 0;
            // 
            // btnBackHomeAnnouncement
            // 
            this.btnBackHomeAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHomeAnnouncement.Location = new System.Drawing.Point(28, 553);
            this.btnBackHomeAnnouncement.Name = "btnBackHomeAnnouncement";
            this.btnBackHomeAnnouncement.Size = new System.Drawing.Size(82, 44);
            this.btnBackHomeAnnouncement.TabIndex = 1;
            this.btnBackHomeAnnouncement.Text = "Back";
            this.btnBackHomeAnnouncement.UseVisualStyleBackColor = true;
            this.btnBackHomeAnnouncement.Click += new System.EventHandler(this.btnBackHomeAnnouncement_Click);
            // 
            // Home_Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 609);
            this.Controls.Add(this.btnBackHomeAnnouncement);
            this.Controls.Add(this.dgvHomeAnnouncement);
            this.Name = "Home_Announcement";
            this.Text = "Home_Announcement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeAnnouncement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHomeAnnouncement;
        private System.Windows.Forms.Button btnBackHomeAnnouncement;
    }
}