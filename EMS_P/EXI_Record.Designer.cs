namespace EMS_P
{
    partial class EXI_Record
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
            this.lblSlotsRecord = new System.Windows.Forms.Label();
            this.dgvSlotsRecord = new System.Windows.Forms.DataGridView();
            this.btnBackEXI_record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotsRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlotsRecord
            // 
            this.lblSlotsRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblSlotsRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotsRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSlotsRecord.Location = new System.Drawing.Point(535, 110);
            this.lblSlotsRecord.Name = "lblSlotsRecord";
            this.lblSlotsRecord.Size = new System.Drawing.Size(286, 54);
            this.lblSlotsRecord.TabIndex = 0;
            this.lblSlotsRecord.Text = "Slots Record";
            // 
            // dgvSlotsRecord
            // 
            this.dgvSlotsRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlotsRecord.Location = new System.Drawing.Point(141, 167);
            this.dgvSlotsRecord.Name = "dgvSlotsRecord";
            this.dgvSlotsRecord.RowTemplate.Height = 24;
            this.dgvSlotsRecord.Size = new System.Drawing.Size(993, 370);
            this.dgvSlotsRecord.TabIndex = 1;
            // 
            // btnBackEXI_record
            // 
            this.btnBackEXI_record.BackColor = System.Drawing.Color.Aqua;
            this.btnBackEXI_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEXI_record.Location = new System.Drawing.Point(12, 608);
            this.btnBackEXI_record.Name = "btnBackEXI_record";
            this.btnBackEXI_record.Size = new System.Drawing.Size(90, 34);
            this.btnBackEXI_record.TabIndex = 2;
            this.btnBackEXI_record.Text = "Back";
            this.btnBackEXI_record.UseVisualStyleBackColor = false;
            this.btnBackEXI_record.Click += new System.EventHandler(this.btnBackEXI_record_Click);
            // 
            // EXI_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.pngtree_modern_double_color_futuristic_neon_background_image_351866_1_1255x7001;
            this.ClientSize = new System.Drawing.Size(1226, 654);
            this.Controls.Add(this.btnBackEXI_record);
            this.Controls.Add(this.dgvSlotsRecord);
            this.Controls.Add(this.lblSlotsRecord);
            this.Name = "EXI_Record";
            this.Text = "EXI_Record";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotsRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSlotsRecord;
        private System.Windows.Forms.DataGridView dgvSlotsRecord;
        private System.Windows.Forms.Button btnBackEXI_record;
    }
}