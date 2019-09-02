namespace KelimeEzber.WinForm
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kelimeHavuzuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHavuzOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havuzlarımıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeTransferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilBilgileriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGetPay = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeHavuzuToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kelimeHavuzuToolStripMenuItem
            // 
            this.kelimeHavuzuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHavuzOluşturToolStripMenuItem,
            this.havuzlarımıListeleToolStripMenuItem,
            this.kelimeTransferiToolStripMenuItem});
            this.kelimeHavuzuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kelimeHavuzuToolStripMenuItem.Name = "kelimeHavuzuToolStripMenuItem";
            this.kelimeHavuzuToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.kelimeHavuzuToolStripMenuItem.Text = "Kelime Havuzu";
            // 
            // yeniHavuzOluşturToolStripMenuItem
            // 
            this.yeniHavuzOluşturToolStripMenuItem.Name = "yeniHavuzOluşturToolStripMenuItem";
            this.yeniHavuzOluşturToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.yeniHavuzOluşturToolStripMenuItem.Text = "Yeni Havuz Oluştur";
            this.yeniHavuzOluşturToolStripMenuItem.Click += new System.EventHandler(this.YeniHavuzOluşturToolStripMenuItem_Click);
            // 
            // havuzlarımıListeleToolStripMenuItem
            // 
            this.havuzlarımıListeleToolStripMenuItem.Name = "havuzlarımıListeleToolStripMenuItem";
            this.havuzlarımıListeleToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.havuzlarımıListeleToolStripMenuItem.Text = "Havuzlarımı Listele";
            this.havuzlarımıListeleToolStripMenuItem.Click += new System.EventHandler(this.HavuzlarımıListeleToolStripMenuItem_Click);
            // 
            // kelimeTransferiToolStripMenuItem
            // 
            this.kelimeTransferiToolStripMenuItem.Name = "kelimeTransferiToolStripMenuItem";
            this.kelimeTransferiToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.kelimeTransferiToolStripMenuItem.Text = "Kelime Transferi";
            this.kelimeTransferiToolStripMenuItem.Click += new System.EventHandler(this.KelimeTransferiToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilBilgileriniGüncelleToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // profilBilgileriniGüncelleToolStripMenuItem
            // 
            this.profilBilgileriniGüncelleToolStripMenuItem.Name = "profilBilgileriniGüncelleToolStripMenuItem";
            this.profilBilgileriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.profilBilgileriniGüncelleToolStripMenuItem.Text = "Profil Bilgileri Güncelle";
            this.profilBilgileriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ProfilBilgileriniGüncelleToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.ŞifreDeğiştirToolStripMenuItem_Click);
            // 
            // lblGetPay
            // 
            this.lblGetPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGetPay.AutoSize = true;
            this.lblGetPay.Location = new System.Drawing.Point(908, 5);
            this.lblGetPay.Name = "lblGetPay";
            this.lblGetPay.Size = new System.Drawing.Size(158, 20);
            this.lblGetPay.TabIndex = 3;
            this.lblGetPay.TabStop = true;
            this.lblGetPay.Text = "Hesabınızı yükseltin";
            this.lblGetPay.Visible = false;
            this.lblGetPay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblGetPay_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblGetPay);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Kelime Ezber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem kelimeHavuzuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yeniHavuzOluşturToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem havuzlarımıListeleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profilBilgileriniGüncelleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblGetPay;
        private System.Windows.Forms.ToolStripMenuItem kelimeTransferiToolStripMenuItem;
    }
}