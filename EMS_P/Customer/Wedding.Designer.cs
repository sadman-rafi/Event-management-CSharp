namespace EMS_P
{
    partial class Wedding
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
            this.btnBackWedding = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnSlotsWedding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackWedding
            // 
            this.btnBackWedding.BackColor = System.Drawing.Color.White;
            this.btnBackWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackWedding.Location = new System.Drawing.Point(916, 595);
            this.btnBackWedding.Name = "btnBackWedding";
            this.btnBackWedding.Size = new System.Drawing.Size(84, 35);
            this.btnBackWedding.TabIndex = 0;
            this.btnBackWedding.Text = "Back";
            this.btnBackWedding.UseVisualStyleBackColor = false;
            this.btnBackWedding.Click += new System.EventHandler(this.btnBackWedding_Click);
            // 
            // btnOffers
            // 
            this.btnOffers.BackColor = System.Drawing.Color.White;
            this.btnOffers.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffers.Location = new System.Drawing.Point(473, 324);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(132, 61);
            this.btnOffers.TabIndex = 1;
            this.btnOffers.Text = "OFFERS";
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
            // 
            // btnSlotsWedding
            // 
            this.btnSlotsWedding.BackColor = System.Drawing.Color.White;
            this.btnSlotsWedding.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlotsWedding.Location = new System.Drawing.Point(473, 420);
            this.btnSlotsWedding.Name = "btnSlotsWedding";
            this.btnSlotsWedding.Size = new System.Drawing.Size(132, 61);
            this.btnSlotsWedding.TabIndex = 2;
            this.btnSlotsWedding.Text = "Slots";
            this.btnSlotsWedding.UseVisualStyleBackColor = false;
            this.btnSlotsWedding.Click += new System.EventHandler(this.btnSlotsWedding_Click);
            // 
            // Wedding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.photo_1469371670807_013ccf25f16a;
            this.ClientSize = new System.Drawing.Size(1001, 630);
            this.Controls.Add(this.btnSlotsWedding);
            this.Controls.Add(this.btnOffers);
            this.Controls.Add(this.btnBackWedding);
            this.Name = "Wedding";
            this.Text = "Wedding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackWedding;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnSlotsWedding;
    }
}