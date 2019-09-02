namespace KelimeEzber.WinForm
{
    partial class frmAllMember
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
			this.lstAllMember = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lstAllMember
			// 
			this.lstAllMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lstAllMember.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstAllMember.GridLines = true;
			this.lstAllMember.Location = new System.Drawing.Point(0, 0);
			this.lstAllMember.Name = "lstAllMember";
			this.lstAllMember.Size = new System.Drawing.Size(757, 450);
			this.lstAllMember.TabIndex = 0;
			this.lstAllMember.UseCompatibleStateImageBehavior = false;
			this.lstAllMember.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Statü";
			this.columnHeader1.Width = 86;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "İsim";
			this.columnHeader2.Width = 112;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Soyisim";
			this.columnHeader3.Width = 105;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "E-Mail";
			this.columnHeader4.Width = 118;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Doğum Tarihi";
			this.columnHeader5.Width = 103;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aktiflik Durumu";
			this.columnHeader6.Width = 106;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Üye Olma Tarihi";
			this.columnHeader7.Width = 122;
			// 
			// frmAllMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 450);
			this.Controls.Add(this.lstAllMember);
			this.Name = "frmAllMember";
			this.Text = "Bütün Üyeleri Görüntüle";
			this.Load += new System.EventHandler(this.frmAllMember_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstAllMember;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}