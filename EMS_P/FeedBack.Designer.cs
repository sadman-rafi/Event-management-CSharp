namespace EMS_P
{
    partial class FeedBack
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
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(249, 285);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(770, 166);
            this.txtFeedback.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feedback";
            // 
            // btnBackFeedback
            // 
            this.btnBackFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBackFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFeedback.Location = new System.Drawing.Point(23, 586);
            this.btnBackFeedback.Name = "btnBackFeedback";
            this.btnBackFeedback.Size = new System.Drawing.Size(98, 34);
            this.btnBackFeedback.TabIndex = 2;
            this.btnBackFeedback.Text = "Back";
            this.btnBackFeedback.UseVisualStyleBackColor = false;
            this.btnBackFeedback.Click += new System.EventHandler(this.btnBackFeedback_Click);
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.pngtree_orange_gold_autumn_october_thanksgiving_feedback_background_image_267032_1255x700;
            this.ClientSize = new System.Drawing.Size(1196, 632);
            this.Controls.Add(this.btnBackFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFeedback);
            this.Name = "FeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedBack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackFeedback;
    }
}