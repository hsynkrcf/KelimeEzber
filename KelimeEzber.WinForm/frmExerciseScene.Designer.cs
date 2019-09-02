namespace KelimeEzber.WinForm
{
	partial class frmExerciseScene
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbWrong = new System.Windows.Forms.PictureBox();
            this.pbTrue = new System.Windows.Forms.PictureBox();
            this.btnExerciseOver = new System.Windows.Forms.Button();
            this.lblExerciseType = new System.Windows.Forms.Label();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(134, 39);
            this.lblWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(46, 17);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label1";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(21, 96);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(212, 23);
            this.txtAnswer.TabIndex = 0;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(101, 245);
            this.btnControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(95, 54);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Kontrol Et";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbWrong);
            this.groupBox1.Controls.Add(this.pbTrue);
            this.groupBox1.Controls.Add(this.txtAnswer);
            this.groupBox1.Controls.Add(this.lblWord);
            this.groupBox1.Location = new System.Drawing.Point(86, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pbWrong
            // 
            this.pbWrong.Image = global::KelimeEzber.WinForm.Properties.Resources.wrong;
            this.pbWrong.Location = new System.Drawing.Point(241, 96);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(25, 23);
            this.pbWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWrong.TabIndex = 2;
            this.pbWrong.TabStop = false;
            this.pbWrong.Visible = false;
            // 
            // pbTrue
            // 
            this.pbTrue.Image = global::KelimeEzber.WinForm.Properties.Resources._true;
            this.pbTrue.Location = new System.Drawing.Point(241, 96);
            this.pbTrue.Name = "pbTrue";
            this.pbTrue.Size = new System.Drawing.Size(25, 23);
            this.pbTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrue.TabIndex = 2;
            this.pbTrue.TabStop = false;
            this.pbTrue.Visible = false;
            // 
            // btnExerciseOver
            // 
            this.btnExerciseOver.Location = new System.Drawing.Point(307, 245);
            this.btnExerciseOver.Margin = new System.Windows.Forms.Padding(4);
            this.btnExerciseOver.Name = "btnExerciseOver";
            this.btnExerciseOver.Size = new System.Drawing.Size(100, 54);
            this.btnExerciseOver.TabIndex = 2;
            this.btnExerciseOver.Text = "Alıştırmayı Sonlandır";
            this.btnExerciseOver.UseVisualStyleBackColor = true;
            this.btnExerciseOver.Click += new System.EventHandler(this.BtnExerciseOver_Click);
            // 
            // lblExerciseType
            // 
            this.lblExerciseType.AutoSize = true;
            this.lblExerciseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExerciseType.Location = new System.Drawing.Point(30, 29);
            this.lblExerciseType.Name = "lblExerciseType";
            this.lblExerciseType.Size = new System.Drawing.Size(57, 20);
            this.lblExerciseType.TabIndex = 4;
            this.lblExerciseType.Text = "label1";
            // 
            // btnNextWord
            // 
            this.btnNextWord.Enabled = false;
            this.btnNextWord.Location = new System.Drawing.Point(204, 245);
            this.btnNextWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(95, 54);
            this.btnNextWord.TabIndex = 1;
            this.btnNextWord.Text = "Sonraki Kelime";
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.BtnNextWord_Click);
            // 
            // frmExerciseScene
            // 
            this.AcceptButton = this.btnNextWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.lblExerciseType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExerciseOver);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.btnControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExerciseScene";
            this.Text = "Kelime Ezber";
            this.Load += new System.EventHandler(this.FrmExerciseScene_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWord;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnControl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExerciseOver;
		private System.Windows.Forms.Label lblExerciseType;
		private System.Windows.Forms.PictureBox pbWrong;
		private System.Windows.Forms.PictureBox pbTrue;
		private System.Windows.Forms.Button btnNextWord;
	}
}