namespace KelimeEzber.WinForm
{
	partial class frmReports
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupUsers = new System.Windows.Forms.GroupBox();
            this.btnHowManyExercise = new System.Windows.Forms.Button();
            this.btnHowManyWord = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupWords = new System.Windows.Forms.GroupBox();
            this.lviAllWords = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHowManyPool = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnStandartMembers = new System.Windows.Forms.Button();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.groupUsers.SuspendLayout();
            this.groupWords.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(7, 65);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(265, 23);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(298, 65);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(265, 23);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // groupUsers
            // 
            this.groupUsers.Controls.Add(this.btnHowManyExercise);
            this.groupUsers.Controls.Add(this.btnHowManyWord);
            this.groupUsers.Controls.Add(this.lstUsers);
            this.groupUsers.Location = new System.Drawing.Point(23, 154);
            this.groupUsers.Name = "groupUsers";
            this.groupUsers.Size = new System.Drawing.Size(334, 330);
            this.groupUsers.TabIndex = 3;
            this.groupUsers.TabStop = false;
            // 
            // btnHowManyExercise
            // 
            this.btnHowManyExercise.Location = new System.Drawing.Point(225, 207);
            this.btnHowManyExercise.Name = "btnHowManyExercise";
            this.btnHowManyExercise.Size = new System.Drawing.Size(94, 82);
            this.btnHowManyExercise.TabIndex = 1;
            this.btnHowManyExercise.Text = "Kaç Alıştırma Yaptı?";
            this.btnHowManyExercise.UseVisualStyleBackColor = true;
            this.btnHowManyExercise.Click += new System.EventHandler(this.btnHowManyExercise_Click);
            // 
            // btnHowManyWord
            // 
            this.btnHowManyWord.Location = new System.Drawing.Point(225, 57);
            this.btnHowManyWord.Name = "btnHowManyWord";
            this.btnHowManyWord.Size = new System.Drawing.Size(94, 86);
            this.btnHowManyWord.TabIndex = 0;
            this.btnHowManyWord.Text = "Kaç Kelime Ekledi?";
            this.btnHowManyWord.UseVisualStyleBackColor = true;
            this.btnHowManyWord.Click += new System.EventHandler(this.btnHowManyWord_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstUsers.Location = new System.Drawing.Point(7, 23);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(199, 301);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcılar";
            this.columnHeader1.Width = 194;
            // 
            // groupWords
            // 
            this.groupWords.Controls.Add(this.lviAllWords);
            this.groupWords.Controls.Add(this.btnHowManyPool);
            this.groupWords.Location = new System.Drawing.Point(440, 154);
            this.groupWords.Name = "groupWords";
            this.groupWords.Size = new System.Drawing.Size(357, 330);
            this.groupWords.TabIndex = 4;
            this.groupWords.TabStop = false;
            // 
            // lviAllWords
            // 
            this.lviAllWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lviAllWords.Location = new System.Drawing.Point(6, 22);
            this.lviAllWords.Name = "lviAllWords";
            this.lviAllWords.Size = new System.Drawing.Size(345, 224);
            this.lviAllWords.TabIndex = 6;
            this.lviAllWords.UseCompatibleStateImageBehavior = false;
            this.lviAllWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kelimeler";
            this.columnHeader3.Width = 339;
            // 
            // btnHowManyPool
            // 
            this.btnHowManyPool.Location = new System.Drawing.Point(130, 263);
            this.btnHowManyPool.Name = "btnHowManyPool";
            this.btnHowManyPool.Size = new System.Drawing.Size(96, 61);
            this.btnHowManyPool.TabIndex = 0;
            this.btnHowManyPool.Text = "Kaç Kez Havuza Eklenmiş?";
            this.btnHowManyPool.UseVisualStyleBackColor = true;
            this.btnHowManyPool.Click += new System.EventHandler(this.btnHowManyPool_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(619, 82);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(85, 68);
            this.btnRevenue.TabIndex = 0;
            this.btnRevenue.Text = "Ciro";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnStandartMembers
            // 
            this.btnStandartMembers.Location = new System.Drawing.Point(712, 82);
            this.btnStandartMembers.Name = "btnStandartMembers";
            this.btnStandartMembers.Size = new System.Drawing.Size(85, 68);
            this.btnStandartMembers.TabIndex = 1;
            this.btnStandartMembers.Text = "Standat Üyelerin Sayısı";
            this.btnStandartMembers.UseVisualStyleBackColor = true;
            this.btnStandartMembers.Click += new System.EventHandler(this.BtnStandartMembers_Click);
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.label1);
            this.groupDate.Controls.Add(this.dtpStartDate);
            this.groupDate.Controls.Add(this.dtpEndDate);
            this.groupDate.Controls.Add(this.label2);
            this.groupDate.Location = new System.Drawing.Point(23, 30);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(590, 118);
            this.groupDate.TabIndex = 6;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Tarih Seç";
            this.groupDate.Visible = false;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 527);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.btnStandartMembers);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.groupWords);
            this.Controls.Add(this.groupUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.groupUsers.ResumeLayout(false);
            this.groupWords.ResumeLayout(false);
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupUsers;
		private System.Windows.Forms.Button btnHowManyExercise;
		private System.Windows.Forms.Button btnHowManyWord;
		private System.Windows.Forms.ListView lstUsers;
		private System.Windows.Forms.GroupBox groupWords;
		private System.Windows.Forms.Button btnHowManyPool;
		private System.Windows.Forms.Button btnRevenue;
		private System.Windows.Forms.Button btnStandartMembers;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lviAllWords;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupDate;
    }
}