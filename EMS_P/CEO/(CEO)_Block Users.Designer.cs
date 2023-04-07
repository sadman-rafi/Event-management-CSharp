namespace EMS_P
{
    partial class _CEO__Block_Users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdsearchtoblock = new System.Windows.Forms.TextBox();
            this.dgvBlockUserFromCEO = new System.Windows.Forms.DataGridView();
            this.btnBlockID = new System.Windows.Forms.Button();
            this.btnBackBlockID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockUserFromCEO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EMS_P.Properties.Resources._94_940382_png_50_px_block_user_icon_173x125;
            this.panel1.Location = new System.Drawing.Point(44, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(63, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block User";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search ID to block user";
            // 
            // txtIdsearchtoblock
            // 
            this.txtIdsearchtoblock.Location = new System.Drawing.Point(44, 381);
            this.txtIdsearchtoblock.Multiline = true;
            this.txtIdsearchtoblock.Name = "txtIdsearchtoblock";
            this.txtIdsearchtoblock.Size = new System.Drawing.Size(272, 43);
            this.txtIdsearchtoblock.TabIndex = 3;
            // 
            // dgvBlockUserFromCEO
            // 
            this.dgvBlockUserFromCEO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlockUserFromCEO.Location = new System.Drawing.Point(444, 66);
            this.dgvBlockUserFromCEO.Name = "dgvBlockUserFromCEO";
            this.dgvBlockUserFromCEO.RowTemplate.Height = 24;
            this.dgvBlockUserFromCEO.Size = new System.Drawing.Size(782, 508);
            this.dgvBlockUserFromCEO.TabIndex = 4;
            // 
            // btnBlockID
            // 
            this.btnBlockID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlockID.ForeColor = System.Drawing.Color.Red;
            this.btnBlockID.Location = new System.Drawing.Point(44, 446);
            this.btnBlockID.Name = "btnBlockID";
            this.btnBlockID.Size = new System.Drawing.Size(97, 39);
            this.btnBlockID.TabIndex = 5;
            this.btnBlockID.Text = "Block";
            this.btnBlockID.UseVisualStyleBackColor = false;
            // 
            // btnBackBlockID
            // 
            this.btnBackBlockID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackBlockID.Location = new System.Drawing.Point(12, 603);
            this.btnBackBlockID.Name = "btnBackBlockID";
            this.btnBackBlockID.Size = new System.Drawing.Size(94, 31);
            this.btnBackBlockID.TabIndex = 6;
            this.btnBackBlockID.Text = "Back";
            this.btnBackBlockID.UseVisualStyleBackColor = false;
            this.btnBackBlockID.Click += new System.EventHandler(this.btnBackBlockID_Click);
            // 
            // _CEO__Block_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.af8d63a477078732b79ff9d9fc60873f_1255x700;
            this.ClientSize = new System.Drawing.Size(1238, 646);
            this.Controls.Add(this.btnBackBlockID);
            this.Controls.Add(this.btnBlockID);
            this.Controls.Add(this.dgvBlockUserFromCEO);
            this.Controls.Add(this.txtIdsearchtoblock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "_CEO__Block_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockUserFromCEO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdsearchtoblock;
        private System.Windows.Forms.DataGridView dgvBlockUserFromCEO;
        private System.Windows.Forms.Button btnBlockID;
        private System.Windows.Forms.Button btnBackBlockID;
    }
}