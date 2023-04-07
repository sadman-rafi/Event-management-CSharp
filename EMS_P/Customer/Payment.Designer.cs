namespace EMS_P
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNOC = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblIDpayment = new System.Windows.Forms.Label();
            this.lblNamepayment = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dgvIDpayment = new System.Windows.Forms.DataGridView();
            this.dgvNamepayment = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBackPayment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDpayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamepayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 560);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(823, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtCardName);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.txtCardNumber);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.lblNOC);
            this.panel1.Controls.Add(this.lblCardNumber);
            this.panel1.Location = new System.Drawing.Point(278, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 200);
            this.panel1.TabIndex = 2;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(19, 149);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(199, 22);
            this.txtCardName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(19, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(199, 22);
            this.txtCode.TabIndex = 4;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(19, 41);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(199, 22);
            this.txtCardNumber.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(15, 66);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 23);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblNOC
            // 
            this.lblNOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOC.Location = new System.Drawing.Point(15, 123);
            this.lblNOC.Name = "lblNOC";
            this.lblNOC.Size = new System.Drawing.Size(143, 23);
            this.lblNOC.TabIndex = 1;
            this.lblNOC.Text = "Name of card";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(15, 18);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(143, 23);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblIDpayment
            // 
            this.lblIDpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDpayment.Location = new System.Drawing.Point(578, 219);
            this.lblIDpayment.Name = "lblIDpayment";
            this.lblIDpayment.Size = new System.Drawing.Size(82, 41);
            this.lblIDpayment.TabIndex = 6;
            this.lblIDpayment.Text = "ID";
            // 
            // lblNamepayment
            // 
            this.lblNamepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamepayment.Location = new System.Drawing.Point(578, 313);
            this.lblNamepayment.Name = "lblNamepayment";
            this.lblNamepayment.Size = new System.Drawing.Size(82, 41);
            this.lblNamepayment.TabIndex = 7;
            this.lblNamepayment.Text = "Name";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(578, 405);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 41);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // dgvIDpayment
            // 
            this.dgvIDpayment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvIDpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDpayment.Location = new System.Drawing.Point(569, 251);
            this.dgvIDpayment.Name = "dgvIDpayment";
            this.dgvIDpayment.RowTemplate.Height = 24;
            this.dgvIDpayment.Size = new System.Drawing.Size(240, 46);
            this.dgvIDpayment.TabIndex = 9;
            // 
            // dgvNamepayment
            // 
            this.dgvNamepayment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNamepayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamepayment.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvNamepayment.Location = new System.Drawing.Point(569, 348);
            this.dgvNamepayment.Name = "dgvNamepayment";
            this.dgvNamepayment.RowTemplate.Height = 24;
            this.dgvNamepayment.Size = new System.Drawing.Size(240, 46);
            this.dgvNamepayment.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(569, 434);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 33);
            this.txtAmount.TabIndex = 6;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.Location = new System.Drawing.Point(413, 496);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(105, 46);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnBackPayment
            // 
            this.btnBackPayment.BackColor = System.Drawing.Color.Blue;
            this.btnBackPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackPayment.Location = new System.Drawing.Point(704, 513);
            this.btnBackPayment.Name = "btnBackPayment";
            this.btnBackPayment.Size = new System.Drawing.Size(105, 29);
            this.btnBackPayment.TabIndex = 12;
            this.btnBackPayment.Text = "Back";
            this.btnBackPayment.UseVisualStyleBackColor = false;
            this.btnBackPayment.Click += new System.EventHandler(this.btnBackPayment_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::EMS_P.Properties.Resources.download_85x50;
            this.label4.Location = new System.Drawing.Point(409, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 46);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::EMS_P.Properties.Resources._35_351793_credit_or_debit_card_mastercard_logo_visa_card_1_85x50;
            this.label3.Location = new System.Drawing.Point(321, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 46);
            this.label3.TabIndex = 13;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackPayment);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dgvNamepayment);
            this.Controls.Add(this.dgvIDpayment);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNamepayment);
            this.Controls.Add(this.lblIDpayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDpayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamepayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNOC;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblIDpayment;
        private System.Windows.Forms.Label lblNamepayment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridView dgvIDpayment;
        private System.Windows.Forms.DataGridView dgvNamepayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBackPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}