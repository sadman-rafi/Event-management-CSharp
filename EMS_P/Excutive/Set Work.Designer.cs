namespace EMS_P
{
    partial class Set_Work
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
            this.lblIDSET_WORK = new System.Windows.Forms.Label();
            this.txtIDsetWork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSetWork = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPushWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(376, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Work";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIDSET_WORK
            // 
            this.lblIDSET_WORK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSET_WORK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIDSET_WORK.Location = new System.Drawing.Point(28, 179);
            this.lblIDSET_WORK.Name = "lblIDSET_WORK";
            this.lblIDSET_WORK.Size = new System.Drawing.Size(160, 53);
            this.lblIDSET_WORK.TabIndex = 1;
            this.lblIDSET_WORK.Text = "ID:";
            this.lblIDSET_WORK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIDsetWork
            // 
            this.txtIDsetWork.Location = new System.Drawing.Point(225, 179);
            this.txtIDsetWork.Multiline = true;
            this.txtIDsetWork.Name = "txtIDsetWork";
            this.txtIDsetWork.Size = new System.Drawing.Size(128, 36);
            this.txtIDsetWork.TabIndex = 2;
            this.txtIDsetWork.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set Work";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSetWork
            // 
            this.txtSetWork.Location = new System.Drawing.Point(60, 317);
            this.txtSetWork.Multiline = true;
            this.txtSetWork.Name = "txtSetWork";
            this.txtSetWork.Size = new System.Drawing.Size(825, 168);
            this.txtSetWork.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPushWork
            // 
            this.btnPushWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPushWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushWork.Location = new System.Drawing.Point(929, 379);
            this.btnPushWork.Name = "btnPushWork";
            this.btnPushWork.Size = new System.Drawing.Size(134, 46);
            this.btnPushWork.TabIndex = 6;
            this.btnPushWork.Text = "Push Work";
            this.btnPushWork.UseVisualStyleBackColor = false;
            // 
            // Set_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 631);
            this.Controls.Add(this.btnPushWork);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSetWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDsetWork);
            this.Controls.Add(this.lblIDSET_WORK);
            this.Controls.Add(this.label1);
            this.Name = "Set_Work";
            this.Text = "Set_Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDSET_WORK;
        private System.Windows.Forms.TextBox txtIDsetWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetWork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPushWork;
    }
}