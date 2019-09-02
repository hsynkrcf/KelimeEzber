namespace KelimeEzber.WinForm
{
	partial class frmNewPool
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
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.txtPoolName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExerciseType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreatePool = new System.Windows.Forms.Button();
            this.lstAllWords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstUserWords = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(346, 107);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(116, 59);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Kelime Ekle";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.BtnAddWord_Click);
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Location = new System.Drawing.Point(346, 321);
            this.btnRemoveWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(116, 59);
            this.btnRemoveWord.TabIndex = 3;
            this.btnRemoveWord.Text = "Kelime Çıkart";
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.BtnRemoveWord_Click);
            // 
            // txtPoolName
            // 
            this.txtPoolName.Location = new System.Drawing.Point(96, 14);
            this.txtPoolName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoolName.Name = "txtPoolName";
            this.txtPoolName.Size = new System.Drawing.Size(239, 23);
            this.txtPoolName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Havuz İsmi :";
            // 
            // cmbExerciseType
            // 
            this.cmbExerciseType.FormattingEnabled = true;
            this.cmbExerciseType.Location = new System.Drawing.Point(447, 14);
            this.cmbExerciseType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExerciseType.Name = "cmbExerciseType";
            this.cmbExerciseType.Size = new System.Drawing.Size(239, 24);
            this.cmbExerciseType.TabIndex = 1;
            this.cmbExerciseType.SelectedIndexChanged += new System.EventHandler(this.CmbExerciseType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alıştırma Tipi :";
            // 
            // btnCreatePool
            // 
            this.btnCreatePool.Location = new System.Drawing.Point(698, 8);
            this.btnCreatePool.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePool.Name = "btnCreatePool";
            this.btnCreatePool.Size = new System.Drawing.Size(112, 34);
            this.btnCreatePool.TabIndex = 4;
            this.btnCreatePool.Text = "Havuz Oluştur";
            this.btnCreatePool.UseVisualStyleBackColor = true;
            this.btnCreatePool.Click += new System.EventHandler(this.BtnCreatePool_Click);
            // 
            // lstAllWords
            // 
            this.lstAllWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstAllWords.FullRowSelect = true;
            this.lstAllWords.GridLines = true;
            this.lstAllWords.Location = new System.Drawing.Point(7, 44);
            this.lstAllWords.Name = "lstAllWords";
            this.lstAllWords.Size = new System.Drawing.Size(328, 427);
            this.lstAllWords.TabIndex = 8;
            this.lstAllWords.UseCompatibleStateImageBehavior = false;
            this.lstAllWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kelimeler";
            this.columnHeader1.Width = 310;
            // 
            // lstUserWords
            // 
            this.lstUserWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstUserWords.GridLines = true;
            this.lstUserWords.Location = new System.Drawing.Point(475, 45);
            this.lstUserWords.Name = "lstUserWords";
            this.lstUserWords.Size = new System.Drawing.Size(328, 427);
            this.lstUserWords.TabIndex = 8;
            this.lstUserWords.UseCompatibleStateImageBehavior = false;
            this.lstUserWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kelimeler";
            this.columnHeader2.Width = 309;
            // 
            // frmNewPool
            // 
            this.AcceptButton = this.btnCreatePool;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 483);
            this.Controls.Add(this.lstUserWords);
            this.Controls.Add(this.lstAllWords);
            this.Controls.Add(this.btnCreatePool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbExerciseType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoolName);
            this.Controls.Add(this.btnRemoveWord);
            this.Controls.Add(this.btnAddWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewPool";
            this.Text = "Yeni Havuz Oluştur";
            this.Load += new System.EventHandler(this.FrmNewPool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAddWord;
		private System.Windows.Forms.Button btnRemoveWord;
		private System.Windows.Forms.TextBox txtPoolName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbExerciseType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCreatePool;
        private System.Windows.Forms.ListView lstAllWords;
        private System.Windows.Forms.ListView lstUserWords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}