namespace EMS_P
{
    partial class Customer_Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameCD = new System.Windows.Forms.Label();
            this.lblOfferCCD = new System.Windows.Forms.Label();
            this.lblIDCD = new System.Windows.Forms.Label();
            this.btnBackCoustomerD = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxOF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(33, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 574);
            this.label2.TabIndex = 1;
            // 
            // lblNameCD
            // 
            this.lblNameCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCD.Location = new System.Drawing.Point(258, 203);
            this.lblNameCD.Name = "lblNameCD";
            this.lblNameCD.Size = new System.Drawing.Size(100, 23);
            this.lblNameCD.TabIndex = 2;
            this.lblNameCD.Text = "Name";
            // 
            // lblOfferCCD
            // 
            this.lblOfferCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferCCD.Location = new System.Drawing.Point(372, 345);
            this.lblOfferCCD.Name = "lblOfferCCD";
            this.lblOfferCCD.Size = new System.Drawing.Size(163, 23);
            this.lblOfferCCD.TabIndex = 3;
            this.lblOfferCCD.Text = "Offer Choosen";
            // 
            // lblIDCD
            // 
            this.lblIDCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCD.Location = new System.Drawing.Point(670, 203);
            this.lblIDCD.Name = "lblIDCD";
            this.lblIDCD.Size = new System.Drawing.Size(100, 23);
            this.lblIDCD.TabIndex = 4;
            this.lblIDCD.Text = "ID";
            // 
            // btnBackCoustomerD
            // 
            this.btnBackCoustomerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCoustomerD.Location = new System.Drawing.Point(874, 527);
            this.btnBackCoustomerD.Name = "btnBackCoustomerD";
            this.btnBackCoustomerD.Size = new System.Drawing.Size(113, 38);
            this.btnBackCoustomerD.TabIndex = 8;
            this.btnBackCoustomerD.Text = "Back";
            this.btnBackCoustomerD.UseVisualStyleBackColor = true;
            this.btnBackCoustomerD.Click += new System.EventHandler(this.btnBackCoustomerD_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(213, 254);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 60);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(623, 254);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(244, 60);
            this.textBoxID.TabIndex = 10;
            // 
            // textBoxOF
            // 
            this.textBoxOF.Location = new System.Drawing.Point(330, 388);
            this.textBoxOF.Multiline = true;
            this.textBoxOF.Name = "textBoxOF";
            this.textBoxOF.Size = new System.Drawing.Size(244, 60);
            this.textBoxOF.TabIndex = 11;
            // 
            // Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 577);
            this.Controls.Add(this.textBoxOF);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnBackCoustomerD);
            this.Controls.Add(this.lblIDCD);
            this.Controls.Add(this.lblOfferCCD);
            this.Controls.Add(this.lblNameCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Details";
            this.Text = "Customer_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameCD;
        private System.Windows.Forms.Label lblOfferCCD;
        private System.Windows.Forms.Label lblIDCD;
        private System.Windows.Forms.Button btnBackCoustomerD;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxOF;
    }
}