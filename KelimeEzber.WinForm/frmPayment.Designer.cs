namespace KelimeEzber.WinForm
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditPayment = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtCreditNo = new System.Windows.Forms.TextBox();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.creditPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // creditPayment
            // 
            this.creditPayment.Controls.Add(this.lblYear);
            this.creditPayment.Controls.Add(this.lblMonth);
            this.creditPayment.Controls.Add(this.lblSecurity);
            this.creditPayment.Controls.Add(this.lblCreditCard);
            this.creditPayment.Controls.Add(this.txtYear);
            this.creditPayment.Controls.Add(this.txtMonth);
            this.creditPayment.Controls.Add(this.label2);
            this.creditPayment.Controls.Add(this.label1);
            this.creditPayment.Controls.Add(this.txtSecurityCode);
            this.creditPayment.Controls.Add(this.txtCreditNo);
            this.creditPayment.Controls.Add(this.pictureBox1);
            this.creditPayment.Enabled = false;
            this.creditPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.creditPayment.Location = new System.Drawing.Point(21, 70);
            this.creditPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditPayment.Name = "creditPayment";
            this.creditPayment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditPayment.Size = new System.Drawing.Size(541, 268);
            this.creditPayment.TabIndex = 1;
            this.creditPayment.TabStop = false;
            this.creditPayment.Text = "Kredi Kartı İle Ödeme";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblYear.Location = new System.Drawing.Point(296, 194);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Yıl    ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMonth.Location = new System.Drawing.Point(213, 194);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(33, 20);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Ay ";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.BackColor = System.Drawing.Color.Transparent;
            this.lblSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSecurity.Location = new System.Drawing.Point(308, 128);
            this.lblSecurity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(116, 20);
            this.lblSecurity.TabIndex = 8;
            this.lblSecurity.Text = "Güvenlik Kodu";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditCard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCreditCard.Location = new System.Drawing.Point(36, 128);
            this.lblCreditCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(240, 20);
            this.lblCreditCard.TabIndex = 8;
            this.lblCreditCard.Text = "Kredi Kartı Numarası               ";
            // 
            // txtYear
            // 
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(284, 218);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(63, 27);
            this.txtYear.TabIndex = 7;
            // 
            // txtMonth
            // 
            this.txtMonth.ForeColor = System.Drawing.Color.Black;
            this.txtMonth.Location = new System.Drawing.Point(209, 218);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(47, 27);
            this.txtMonth.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Son Kullanma Tarihi";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.ForeColor = System.Drawing.Color.Black;
            this.txtSecurityCode.Location = new System.Drawing.Point(312, 155);
            this.txtSecurityCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(129, 27);
            this.txtSecurityCode.TabIndex = 2;
            // 
            // txtCreditNo
            // 
            this.txtCreditNo.ForeColor = System.Drawing.Color.Black;
            this.txtCreditNo.Location = new System.Drawing.Point(29, 155);
            this.txtCreditNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreditNo.Name = "txtCreditNo";
            this.txtCreditNo.Size = new System.Drawing.Size(276, 27);
            this.txtCreditNo.TabIndex = 1;
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Checked = true;
            this.radioCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCash.Location = new System.Drawing.Point(67, 12);
            this.radioCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(165, 28);
            this.radioCash.TabIndex = 0;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Nakit İle Ödeme";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.RadioCash_CheckedChanged);
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCredit.Location = new System.Drawing.Point(295, 12);
            this.radioCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(209, 28);
            this.radioCredit.TabIndex = 1;
            this.radioCredit.Text = "Kredi Kartı İle Ödeme";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.Location = new System.Drawing.Point(151, 343);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(260, 58);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Ödeme Yap";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 415);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.radioCredit);
            this.Controls.Add(this.creditPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayment";
            this.Text = "Ödeme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPayment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.creditPayment.ResumeLayout(false);
            this.creditPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox creditPayment;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.TextBox txtCreditNo;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblSecurity;
    }
}