namespace EMS_P
{
    partial class Search_Person
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
            this.lblShUsername = new System.Windows.Forms.Label();
            this.lblSHID = new System.Windows.Forms.Label();
            this.txtSHUsername = new System.Windows.Forms.TextBox();
            this.txtSHID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnshBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShUsername
            // 
            this.lblShUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblShUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShUsername.ForeColor = System.Drawing.Color.White;
            this.lblShUsername.Location = new System.Drawing.Point(249, 137);
            this.lblShUsername.Name = "lblShUsername";
            this.lblShUsername.Size = new System.Drawing.Size(141, 42);
            this.lblShUsername.TabIndex = 0;
            this.lblShUsername.Text = "Username";
            // 
            // lblSHID
            // 
            this.lblSHID.BackColor = System.Drawing.Color.Transparent;
            this.lblSHID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHID.ForeColor = System.Drawing.Color.White;
            this.lblSHID.Location = new System.Drawing.Point(643, 137);
            this.lblSHID.Name = "lblSHID";
            this.lblSHID.Size = new System.Drawing.Size(141, 42);
            this.lblSHID.TabIndex = 1;
            this.lblSHID.Text = "ID";
            // 
            // txtSHUsername
            // 
            this.txtSHUsername.Location = new System.Drawing.Point(254, 183);
            this.txtSHUsername.Multiline = true;
            this.txtSHUsername.Name = "txtSHUsername";
            this.txtSHUsername.Size = new System.Drawing.Size(208, 46);
            this.txtSHUsername.TabIndex = 2;
            // 
            // txtSHID
            // 
            this.txtSHID.Location = new System.Drawing.Point(648, 182);
            this.txtSHID.Multiline = true;
            this.txtSHID.Name = "txtSHID";
            this.txtSHID.Size = new System.Drawing.Size(208, 46);
            this.txtSHID.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(489, 266);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvSearch
            // 
            this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.GridColor = System.Drawing.Color.White;
            this.dgvSearch.Location = new System.Drawing.Point(32, 318);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(1029, 266);
            this.dgvSearch.TabIndex = 5;
            // 
            // btnshBack
            // 
            this.btnshBack.BackColor = System.Drawing.Color.Red;
            this.btnshBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshBack.ForeColor = System.Drawing.Color.White;
            this.btnshBack.Location = new System.Drawing.Point(927, 609);
            this.btnshBack.Name = "btnshBack";
            this.btnshBack.Size = new System.Drawing.Size(134, 46);
            this.btnshBack.TabIndex = 6;
            this.btnshBack.Text = "Back";
            this.btnshBack.UseVisualStyleBackColor = false;
            this.btnshBack.Click += new System.EventHandler(this.btnshBack_Click);
            // 
            // Search_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EMS_P.Properties.Resources.cec82d5465d42ae136e627b67dbeb068;
            this.ClientSize = new System.Drawing.Size(1083, 667);
            this.Controls.Add(this.btnshBack);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSHID);
            this.Controls.Add(this.txtSHUsername);
            this.Controls.Add(this.lblSHID);
            this.Controls.Add(this.lblShUsername);
            this.Name = "Search_Person";
            this.Text = "Search_Person";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShUsername;
        private System.Windows.Forms.Label lblSHID;
        private System.Windows.Forms.TextBox txtSHUsername;
        private System.Windows.Forms.TextBox txtSHID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnshBack;
    }
}