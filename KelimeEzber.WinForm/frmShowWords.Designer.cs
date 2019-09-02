namespace KelimeEzber.WinForm
{
	partial class frmShowWords
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
            this.lstAllWords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllWords
            // 
            this.lstAllWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstAllWords.GridLines = true;
            this.lstAllWords.Location = new System.Drawing.Point(0, 0);
            this.lstAllWords.Name = "lstAllWords";
            this.lstAllWords.Size = new System.Drawing.Size(293, 406);
            this.lstAllWords.TabIndex = 0;
            this.lstAllWords.UseCompatibleStateImageBehavior = false;
            this.lstAllWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İngilizce";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Türkçe";
            this.columnHeader2.Width = 146;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(269, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Kelime Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmShowWords
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 458);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAllWords);
            this.Name = "frmShowWords";
            this.Text = "Kelimeleri Görüntüle";
            this.Load += new System.EventHandler(this.frmShowWords_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstAllWords;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdd;
    }
}