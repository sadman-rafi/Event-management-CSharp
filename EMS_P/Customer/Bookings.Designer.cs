namespace EMS_P
{
    partial class Bookings
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
            this.lblNameBooking = new System.Windows.Forms.Label();
            this.lblIDBooking = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.btnBackBooking = new System.Windows.Forms.Button();
            this.lblDateBooking = new System.Windows.Forms.Label();
            this.btnCorpo = new System.Windows.Forms.Button();
            this.btnSCVE = new System.Windows.Forms.Button();
            this.btnWED = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.buttonBirth = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNameBooking
            // 
            this.lblNameBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblNameBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBooking.Location = new System.Drawing.Point(737, 41);
            this.lblNameBooking.Name = "lblNameBooking";
            this.lblNameBooking.Size = new System.Drawing.Size(124, 32);
            this.lblNameBooking.TabIndex = 0;
            this.lblNameBooking.Text = "Name";
            // 
            // lblIDBooking
            // 
            this.lblIDBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblIDBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDBooking.Location = new System.Drawing.Point(737, 134);
            this.lblIDBooking.Name = "lblIDBooking";
            this.lblIDBooking.Size = new System.Drawing.Size(124, 32);
            this.lblIDBooking.TabIndex = 2;
            this.lblIDBooking.Text = "ID";
            this.lblIDBooking.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(742, 86);
            this.txtNameBook.Multiline = true;
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(260, 35);
            this.txtNameBook.TabIndex = 11;
            // 
            // txtIDBook
            // 
            this.txtIDBook.Location = new System.Drawing.Point(742, 169);
            this.txtIDBook.Multiline = true;
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(137, 35);
            this.txtIDBook.TabIndex = 12;
            // 
            // btnBackBooking
            // 
            this.btnBackBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackBooking.Location = new System.Drawing.Point(1024, 472);
            this.btnBackBooking.Name = "btnBackBooking";
            this.btnBackBooking.Size = new System.Drawing.Size(96, 33);
            this.btnBackBooking.TabIndex = 14;
            this.btnBackBooking.Text = "Back";
            this.btnBackBooking.UseVisualStyleBackColor = false;
            this.btnBackBooking.Click += new System.EventHandler(this.btnBackBooking_Click);
            // 
            // lblDateBooking
            // 
            this.lblDateBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblDateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBooking.Location = new System.Drawing.Point(538, 41);
            this.lblDateBooking.Name = "lblDateBooking";
            this.lblDateBooking.Size = new System.Drawing.Size(124, 32);
            this.lblDateBooking.TabIndex = 16;
            this.lblDateBooking.Text = "Date";
            // 
            // btnCorpo
            // 
            this.btnCorpo.Location = new System.Drawing.Point(691, 386);
            this.btnCorpo.Name = "btnCorpo";
            this.btnCorpo.Size = new System.Drawing.Size(126, 32);
            this.btnCorpo.TabIndex = 17;
            this.btnCorpo.Text = "corporate";
            this.btnCorpo.UseVisualStyleBackColor = true;
            this.btnCorpo.Click += new System.EventHandler(this.btnCorpo_Click);
            // 
            // btnSCVE
            // 
            this.btnSCVE.Location = new System.Drawing.Point(843, 386);
            this.btnSCVE.Name = "btnSCVE";
            this.btnSCVE.Size = new System.Drawing.Size(126, 32);
            this.btnSCVE.TabIndex = 18;
            this.btnSCVE.Text = "SCV event";
            this.btnSCVE.UseVisualStyleBackColor = true;
            this.btnSCVE.Click += new System.EventHandler(this.btnSCVE_Click);
            // 
            // btnWED
            // 
            this.btnWED.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWED.Location = new System.Drawing.Point(210, 386);
            this.btnWED.Name = "btnWED";
            this.btnWED.Size = new System.Drawing.Size(126, 32);
            this.btnWED.TabIndex = 19;
            this.btnWED.Text = "Wedding";
            this.btnWED.UseVisualStyleBackColor = false;
            this.btnWED.Click += new System.EventHandler(this.btnWED_Click);
            // 
            // btnHP
            // 
            this.btnHP.BackColor = System.Drawing.Color.White;
            this.btnHP.Location = new System.Drawing.Point(543, 386);
            this.btnHP.Name = "btnHP";
            this.btnHP.Size = new System.Drawing.Size(126, 32);
            this.btnHP.TabIndex = 20;
            this.btnHP.Text = "Home party";
            this.btnHP.UseVisualStyleBackColor = false;
            this.btnHP.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBirth
            // 
            this.buttonBirth.BackColor = System.Drawing.Color.White;
            this.buttonBirth.Location = new System.Drawing.Point(394, 386);
            this.buttonBirth.Name = "buttonBirth";
            this.buttonBirth.Size = new System.Drawing.Size(126, 32);
            this.buttonBirth.TabIndex = 21;
            this.buttonBirth.Text = "Birthday";
            this.buttonBirth.UseVisualStyleBackColor = false;
            this.buttonBirth.Click += new System.EventHandler(this.buttonBirth_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(463, 86);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(260, 35);
            this.textBoxDate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Event";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(463, 169);
            this.textBoxEvent.Multiline = true;
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(260, 35);
            this.textBoxEvent.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Shift";
            // 
            // textBoxShift
            // 
            this.textBoxShift.Location = new System.Drawing.Point(463, 250);
            this.textBoxShift.Multiline = true;
            this.textBoxShift.Name = "textBoxShift";
            this.textBoxShift.Size = new System.Drawing.Size(260, 35);
            this.textBoxShift.TabIndex = 26;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.google_ita_deal_background_forecast_analysis_of_current_situation_1255x700;
            this.ClientSize = new System.Drawing.Size(1175, 518);
            this.Controls.Add(this.textBoxShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonBirth);
            this.Controls.Add(this.btnHP);
            this.Controls.Add(this.btnWED);
            this.Controls.Add(this.btnSCVE);
            this.Controls.Add(this.btnCorpo);
            this.Controls.Add(this.lblDateBooking);
            this.Controls.Add(this.btnBackBooking);
            this.Controls.Add(this.txtIDBook);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.lblIDBooking);
            this.Controls.Add(this.lblNameBooking);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameBooking;
        private System.Windows.Forms.Label lblIDBooking;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.Button btnBackBooking;
        private System.Windows.Forms.Label lblDateBooking;
        private System.Windows.Forms.Button btnCorpo;
        private System.Windows.Forms.Button btnSCVE;
        private System.Windows.Forms.Button btnWED;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button buttonBirth;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShift;
    }
}