namespace KelimeEzber.WinForm
{
    partial class frmAdmin
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
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümÜyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiTarihArasıRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeToolStripMenuItem,
            this.kelimeToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem,
            this.tümÜyeleriGörüntüleToolStripMenuItem});
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.üyeToolStripMenuItem.Text = "Üye";
            // 
            // onaylanmayanÜyeleriGörüntüleToolStripMenuItem
            // 
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem.Name = "onaylanmayanÜyeleriGörüntüleToolStripMenuItem";
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem.Text = "Onaylanmayan Üyeleri Görüntüle";
            this.onaylanmayanÜyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.OnaylanmayanÜyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // tümÜyeleriGörüntüleToolStripMenuItem
            // 
            this.tümÜyeleriGörüntüleToolStripMenuItem.Name = "tümÜyeleriGörüntüleToolStripMenuItem";
            this.tümÜyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.tümÜyeleriGörüntüleToolStripMenuItem.Text = "Tüm Üyeleri Görüntüle";
            this.tümÜyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.TümÜyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // kelimeToolStripMenuItem
            // 
            this.kelimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeEkleToolStripMenuItem,
            this.kelimeleriGörüntüleToolStripMenuItem});
            this.kelimeToolStripMenuItem.Name = "kelimeToolStripMenuItem";
            this.kelimeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kelimeToolStripMenuItem.Text = "Kelime";
            // 
            // kelimeEkleToolStripMenuItem
            // 
            this.kelimeEkleToolStripMenuItem.Name = "kelimeEkleToolStripMenuItem";
            this.kelimeEkleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kelimeEkleToolStripMenuItem.Text = "Kelime Ekle";
            this.kelimeEkleToolStripMenuItem.Visible = false;
            // 
            // kelimeleriGörüntüleToolStripMenuItem
            // 
            this.kelimeleriGörüntüleToolStripMenuItem.Name = "kelimeleriGörüntüleToolStripMenuItem";
            this.kelimeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kelimeleriGörüntüleToolStripMenuItem.Text = "Kelimeleri Görüntüle";
            this.kelimeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kelimeleriGörüntüleToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haftalıkRaporToolStripMenuItem,
            this.aylıkRaporToolStripMenuItem,
            this.ikiTarihArasıRaporToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // haftalıkRaporToolStripMenuItem
            // 
            this.haftalıkRaporToolStripMenuItem.Name = "haftalıkRaporToolStripMenuItem";
            this.haftalıkRaporToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.haftalıkRaporToolStripMenuItem.Text = " Haftalık Rapor";
            this.haftalıkRaporToolStripMenuItem.Click += new System.EventHandler(this.HaftalıkRaporToolStripMenuItem_Click);
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            this.aylıkRaporToolStripMenuItem.Click += new System.EventHandler(this.AylıkRaporToolStripMenuItem_Click);
            // 
            // ikiTarihArasıRaporToolStripMenuItem
            // 
            this.ikiTarihArasıRaporToolStripMenuItem.Name = "ikiTarihArasıRaporToolStripMenuItem";
            this.ikiTarihArasıRaporToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ikiTarihArasıRaporToolStripMenuItem.Text = "İki Tarih Arası Rapor";
            this.ikiTarihArasıRaporToolStripMenuItem.Click += new System.EventHandler(this.İkiTarihArasıRaporToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 520);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.Text = "Admin Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylanmayanÜyeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümÜyeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelimeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftalıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiTarihArasıRaporToolStripMenuItem;
    }
}