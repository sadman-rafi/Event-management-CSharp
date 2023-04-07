namespace EMS_P
{
    partial class AboutUS
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
            this.btnAbountus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbountus
            // 
            this.btnAbountus.Location = new System.Drawing.Point(33, 602);
            this.btnAbountus.Name = "btnAbountus";
            this.btnAbountus.Size = new System.Drawing.Size(89, 32);
            this.btnAbountus.TabIndex = 0;
            this.btnAbountus.Text = "Back";
            this.btnAbountus.UseVisualStyleBackColor = true;
            this.btnAbountus.Click += new System.EventHandler(this.btnAbountus_Click);
            // 
            // AboutUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 646);
            this.Controls.Add(this.btnAbountus);
            this.Name = "AboutUS";
            this.Text = "AboutUS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbountus;
    }
}