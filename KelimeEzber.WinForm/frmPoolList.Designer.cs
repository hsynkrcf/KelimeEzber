namespace KelimeEzber.WinForm
{
	partial class frmPoolList
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
            this.btnDeletePool = new System.Windows.Forms.Button();
            this.btnOpenPool = new System.Windows.Forms.Button();
            this.lvPools = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDeletePool
            // 
            this.btnDeletePool.Enabled = false;
            this.btnDeletePool.Location = new System.Drawing.Point(222, 416);
            this.btnDeletePool.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePool.Name = "btnDeletePool";
            this.btnDeletePool.Size = new System.Drawing.Size(100, 62);
            this.btnDeletePool.TabIndex = 1;
            this.btnDeletePool.Text = "Sil";
            this.btnDeletePool.UseVisualStyleBackColor = true;
            this.btnDeletePool.Click += new System.EventHandler(this.BtnDeletePool_Click);
            // 
            // btnOpenPool
            // 
            this.btnOpenPool.Location = new System.Drawing.Point(66, 416);
            this.btnOpenPool.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPool.Name = "btnOpenPool";
            this.btnOpenPool.Size = new System.Drawing.Size(100, 62);
            this.btnOpenPool.TabIndex = 0;
            this.btnOpenPool.Text = "Aç";
            this.btnOpenPool.UseVisualStyleBackColor = true;
            this.btnOpenPool.Click += new System.EventHandler(this.BtnOpenPool_Click);
            // 
            // lvPools
            // 
            this.lvPools.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPools.FullRowSelect = true;
            this.lvPools.GridLines = true;
            this.lvPools.Location = new System.Drawing.Point(12, 12);
            this.lvPools.Name = "lvPools";
            this.lvPools.Size = new System.Drawing.Size(387, 397);
            this.lvPools.TabIndex = 2;
            this.lvPools.UseCompatibleStateImageBehavior = false;
            this.lvPools.View = System.Windows.Forms.View.Details;
            this.lvPools.SelectedIndexChanged += new System.EventHandler(this.LvPools_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Havuz İsmi";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Egzersiz Türü";
            this.columnHeader2.Width = 203;
            // 
            // frmPoolList
            // 
            this.AcceptButton = this.btnOpenPool;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 491);
            this.Controls.Add(this.lvPools);
            this.Controls.Add(this.btnOpenPool);
            this.Controls.Add(this.btnDeletePool);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPoolList";
            this.Text = "Havuz Listesi";
            this.Load += new System.EventHandler(this.FrmPoolList_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnDeletePool;
		private System.Windows.Forms.Button btnOpenPool;
        private System.Windows.Forms.ListView lvPools;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}