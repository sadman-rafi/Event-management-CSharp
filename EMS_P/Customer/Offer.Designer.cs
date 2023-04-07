namespace EMS_P
{
    partial class Offer
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
            this.btnBackOfferWedding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(275, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 263);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Combined(Photography+food+management+party centre) = 500000 tk\r\n\r\n2.Only food=" +
    "40000 tk\r\n\r\n3.Only photography=18000 tk\r\n\r\n4.Party centre and food =70000 tk\r\n";
            // 
            // btnBackOfferWedding
            // 
            this.btnBackOfferWedding.BackColor = System.Drawing.Color.Blue;
            this.btnBackOfferWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOfferWedding.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackOfferWedding.Location = new System.Drawing.Point(1117, 614);
            this.btnBackOfferWedding.Name = "btnBackOfferWedding";
            this.btnBackOfferWedding.Size = new System.Drawing.Size(75, 35);
            this.btnBackOfferWedding.TabIndex = 1;
            this.btnBackOfferWedding.Text = "Back";
            this.btnBackOfferWedding.UseVisualStyleBackColor = false;
            this.btnBackOfferWedding.Click += new System.EventHandler(this.btnBackOfferWedding_Click);
            // 
            // Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.f9e9a0f68ff7531459d5b1d0be9733be6924121b_1024_1024_1220x700;
            this.ClientSize = new System.Drawing.Size(1204, 649);
            this.Controls.Add(this.btnBackOfferWedding);
            this.Controls.Add(this.label1);
            this.Name = "Offer";
            this.Text = "Offer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackOfferWedding;
    }
}