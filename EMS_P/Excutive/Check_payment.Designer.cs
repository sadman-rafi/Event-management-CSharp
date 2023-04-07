namespace EMS_P
{
    partial class Check_payment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackCheck_payment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBackCheck_payment
            // 
            this.btnBackCheck_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCheck_payment.Location = new System.Drawing.Point(13, 580);
            this.btnBackCheck_payment.Name = "btnBackCheck_payment";
            this.btnBackCheck_payment.Size = new System.Drawing.Size(89, 32);
            this.btnBackCheck_payment.TabIndex = 1;
            this.btnBackCheck_payment.Text = "Back";
            this.btnBackCheck_payment.UseVisualStyleBackColor = true;
            this.btnBackCheck_payment.Click += new System.EventHandler(this.btnBackCheck_payment_Click);
            // 
            // Check_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1193, 624);
            this.Controls.Add(this.btnBackCheck_payment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Check_payment";
            this.Text = "Check_payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackCheck_payment;
    }
}