namespace EMS_P
{
    partial class Customer_Home
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.lblIDCH = new System.Windows.Forms.Label();
            this.lblNameCH = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCslots = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.btnFeedback);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnDC);
            this.panel1.Controls.Add(this.lblIDCH);
            this.panel1.Controls.Add(this.lblNameCH);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 643);
            this.panel1.TabIndex = 0;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Magenta;
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(34, 393);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(127, 60);
            this.btnEditProfile.TabIndex = 8;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Magenta;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(34, 470);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(127, 60);
            this.btnFeedback.TabIndex = 7;
            this.btnFeedback.Text = "Feedbacks";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(34, 558);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(127, 60);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDC
            // 
            this.btnDC.BackColor = System.Drawing.Color.Magenta;
            this.btnDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDC.Location = new System.Drawing.Point(34, 316);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(127, 60);
            this.btnDC.TabIndex = 2;
            this.btnDC.Text = "Details of Customer";
            this.btnDC.UseVisualStyleBackColor = false;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // lblIDCH
            // 
            this.lblIDCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCH.ForeColor = System.Drawing.Color.White;
            this.lblIDCH.Location = new System.Drawing.Point(30, 259);
            this.lblIDCH.Name = "lblIDCH";
            this.lblIDCH.Size = new System.Drawing.Size(100, 23);
            this.lblIDCH.TabIndex = 1;
            this.lblIDCH.Text = "ID";
            // 
            // lblNameCH
            // 
            this.lblNameCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCH.ForeColor = System.Drawing.Color.White;
            this.lblNameCH.Location = new System.Drawing.Point(30, 180);
            this.lblNameCH.Name = "lblNameCH";
            this.lblNameCH.Size = new System.Drawing.Size(249, 49);
            this.lblNameCH.TabIndex = 0;
            this.lblNameCH.Text = "Name";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Magenta;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(472, 317);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(127, 60);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Magenta;
            this.btnSearch.CausesValidation = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(675, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 60);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search person";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCslots
            // 
            this.btnCslots.BackColor = System.Drawing.Color.Magenta;
            this.btnCslots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCslots.Location = new System.Drawing.Point(675, 446);
            this.btnCslots.Name = "btnCslots";
            this.btnCslots.Size = new System.Drawing.Size(127, 60);
            this.btnCslots.TabIndex = 5;
            this.btnCslots.Text = "Check Slots and Offers";
            this.btnCslots.UseVisualStyleBackColor = false;
            this.btnCslots.Click += new System.EventHandler(this.btnCslots_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Magenta;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(895, 317);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 60);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Customer_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources._3958_507D7BBF_CD77_1795_DD85_457D088FF32D;
            this.ClientSize = new System.Drawing.Size(1238, 645);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnCslots);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Home";
            this.Text = "Customer_Home";
            this.Load += new System.EventHandler(this.Customer_Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Label lblIDCH;
        private System.Windows.Forms.Label lblNameCH;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCslots;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnEditProfile;
    }
}