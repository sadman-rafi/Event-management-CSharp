namespace EMS_P
{
    partial class Wedding_Slots
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
            this.dgvWeddingSlots = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackWeddingslots = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeddingSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWeddingSlots
            // 
            this.dgvWeddingSlots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvWeddingSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeddingSlots.Location = new System.Drawing.Point(104, 359);
            this.dgvWeddingSlots.Name = "dgvWeddingSlots";
            this.dgvWeddingSlots.RowTemplate.Height = 24;
            this.dgvWeddingSlots.Size = new System.Drawing.Size(1075, 258);
            this.dgvWeddingSlots.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(547, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Free Slots";
            // 
            // btnBackWeddingslots
            // 
            this.btnBackWeddingslots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBackWeddingslots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackWeddingslots.Location = new System.Drawing.Point(0, 593);
            this.btnBackWeddingslots.Name = "btnBackWeddingslots";
            this.btnBackWeddingslots.Size = new System.Drawing.Size(87, 37);
            this.btnBackWeddingslots.TabIndex = 2;
            this.btnBackWeddingslots.Text = "Back";
            this.btnBackWeddingslots.UseVisualStyleBackColor = false;
            this.btnBackWeddingslots.Click += new System.EventHandler(this.btnBackWeddingslots_Click);
            // 
            // Wedding_Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.istockphoto_856607846_1024x1024_1255x700;
            this.ClientSize = new System.Drawing.Size(1237, 629);
            this.Controls.Add(this.btnBackWeddingslots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWeddingSlots);
            this.Name = "Wedding_Slots";
            this.Text = "Wedding_Slots";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeddingSlots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWeddingSlots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackWeddingslots;
    }
}