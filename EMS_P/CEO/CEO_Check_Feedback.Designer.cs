namespace EMS_P
{
    partial class CEO_Check_Feedback
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
            this.dgvCheckFeedbackBYCEO = new System.Windows.Forms.DataGridView();
            this.btnBackCeoCheckFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckFeedbackBYCEO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckFeedbackBYCEO
            // 
            this.dgvCheckFeedbackBYCEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckFeedbackBYCEO.Location = new System.Drawing.Point(26, 116);
            this.dgvCheckFeedbackBYCEO.Name = "dgvCheckFeedbackBYCEO";
            this.dgvCheckFeedbackBYCEO.RowTemplate.Height = 24;
            this.dgvCheckFeedbackBYCEO.Size = new System.Drawing.Size(1163, 311);
            this.dgvCheckFeedbackBYCEO.TabIndex = 0;
            // 
            // btnBackCeoCheckFeedback
            // 
            this.btnBackCeoCheckFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackCeoCheckFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCeoCheckFeedback.Location = new System.Drawing.Point(26, 590);
            this.btnBackCeoCheckFeedback.Name = "btnBackCeoCheckFeedback";
            this.btnBackCeoCheckFeedback.Size = new System.Drawing.Size(113, 46);
            this.btnBackCeoCheckFeedback.TabIndex = 1;
            this.btnBackCeoCheckFeedback.Text = "Back";
            this.btnBackCeoCheckFeedback.UseVisualStyleBackColor = false;
            this.btnBackCeoCheckFeedback.Click += new System.EventHandler(this.btnBackCeoCheckFeedback_Click);
            // 
            // CEO_Check_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1224, 648);
            this.Controls.Add(this.btnBackCeoCheckFeedback);
            this.Controls.Add(this.dgvCheckFeedbackBYCEO);
            this.Name = "CEO_Check_Feedback";
            this.Text = "CEO_Check_Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckFeedbackBYCEO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckFeedbackBYCEO;
        private System.Windows.Forms.Button btnBackCeoCheckFeedback;
    }
}