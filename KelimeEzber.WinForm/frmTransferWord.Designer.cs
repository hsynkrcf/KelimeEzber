namespace KelimeEzber.WinForm
{
    partial class frmTransferWord
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
            this.cmbFirstPool = new System.Windows.Forms.ComboBox();
            this.cmbSecondPool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstFirstPool = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbFirstPool
            // 
            this.cmbFirstPool.FormattingEnabled = true;
            this.cmbFirstPool.Location = new System.Drawing.Point(83, 23);
            this.cmbFirstPool.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFirstPool.Name = "cmbFirstPool";
            this.cmbFirstPool.Size = new System.Drawing.Size(92, 21);
            this.cmbFirstPool.TabIndex = 0;
            this.cmbFirstPool.SelectedIndexChanged += new System.EventHandler(this.CmbFirstPool_SelectedIndexChanged);
            // 
            // cmbSecondPool
            // 
            this.cmbSecondPool.FormattingEnabled = true;
            this.cmbSecondPool.Location = new System.Drawing.Point(343, 81);
            this.cmbSecondPool.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSecondPool.Name = "cmbSecondPool";
            this.cmbSecondPool.Size = new System.Drawing.Size(92, 21);
            this.cmbSecondPool.TabIndex = 1;
            this.cmbSecondPool.SelectedIndexChanged += new System.EventHandler(this.CmbSecondPool_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birinci Havuz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kelime Eklenecek Havuz";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 133);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Gönder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lstFirstPool
            // 
            this.lstFirstPool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFirstPool.Location = new System.Drawing.Point(12, 64);
            this.lstFirstPool.Name = "lstFirstPool";
            this.lstFirstPool.Size = new System.Drawing.Size(175, 252);
            this.lstFirstPool.TabIndex = 8;
            this.lstFirstPool.UseCompatibleStateImageBehavior = false;
            this.lstFirstPool.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kelime";
            this.columnHeader1.Width = 166;
            // 
            // frmTransferWord
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 338);
            this.Controls.Add(this.lstFirstPool);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSecondPool);
            this.Controls.Add(this.cmbFirstPool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransferWord";
            this.Text = "Havuz Kelime Transferi";
            this.Load += new System.EventHandler(this.FrmTransferWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFirstPool;
        private System.Windows.Forms.ComboBox cmbSecondPool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstFirstPool;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}