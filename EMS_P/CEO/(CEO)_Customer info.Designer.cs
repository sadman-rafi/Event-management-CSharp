namespace EMS_P
{
    partial class _CEO__Customer_info
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
            this.dgvCustomerInfoCeoCheck = new System.Windows.Forms.DataGridView();
            this.btnBackCEOCustomerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfoCeoCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // dgvCustomerInfoCeoCheck
            // 
            this.dgvCustomerInfoCeoCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfoCeoCheck.Location = new System.Drawing.Point(41, 141);
            this.dgvCustomerInfoCeoCheck.Name = "dgvCustomerInfoCeoCheck";
            this.dgvCustomerInfoCeoCheck.RowTemplate.Height = 24;
            this.dgvCustomerInfoCeoCheck.Size = new System.Drawing.Size(1140, 308);
            this.dgvCustomerInfoCeoCheck.TabIndex = 1;
            // 
            // btnBackCEOCustomerInfo
            // 
            this.btnBackCEOCustomerInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackCEOCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCEOCustomerInfo.Location = new System.Drawing.Point(12, 583);
            this.btnBackCEOCustomerInfo.Name = "btnBackCEOCustomerInfo";
            this.btnBackCEOCustomerInfo.Size = new System.Drawing.Size(96, 38);
            this.btnBackCEOCustomerInfo.TabIndex = 2;
            this.btnBackCEOCustomerInfo.Text = "Back";
            this.btnBackCEOCustomerInfo.UseVisualStyleBackColor = false;
            this.btnBackCEOCustomerInfo.Click += new System.EventHandler(this.btnBackCEOCustomerInfo_Click);
            // 
            // _CEO__Customer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 633);
            this.Controls.Add(this.btnBackCEOCustomerInfo);
            this.Controls.Add(this.dgvCustomerInfoCeoCheck);
            this.Controls.Add(this.label1);
            this.Name = "_CEO__Customer_info";
            this.Text = "_CEO__Customer_info";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfoCeoCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomerInfoCeoCheck;
        private System.Windows.Forms.Button btnBackCEOCustomerInfo;
    }
}