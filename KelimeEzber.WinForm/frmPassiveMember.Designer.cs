namespace KelimeEzber.WinForm
{
    partial class frmPassiveMember
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
            this.lstPassiveMembers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActived = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPassiveMembers
            // 
            this.lstPassiveMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstPassiveMembers.FullRowSelect = true;
            this.lstPassiveMembers.GridLines = true;
            this.lstPassiveMembers.Location = new System.Drawing.Point(1, 0);
            this.lstPassiveMembers.MultiSelect = false;
            this.lstPassiveMembers.Name = "lstPassiveMembers";
            this.lstPassiveMembers.Size = new System.Drawing.Size(678, 449);
            this.lstPassiveMembers.TabIndex = 0;
            this.lstPassiveMembers.UseCompatibleStateImageBehavior = false;
            this.lstPassiveMembers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Statü";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-Mail";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doğum Tarihi";
            this.columnHeader5.Width = 127;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Üye Olma Tarihi";
            this.columnHeader6.Width = 162;
            // 
            // btnActived
            // 
            this.btnActived.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnActived.Location = new System.Drawing.Point(685, 12);
            this.btnActived.Name = "btnActived";
            this.btnActived.Size = new System.Drawing.Size(128, 426);
            this.btnActived.TabIndex = 0;
            this.btnActived.Text = "Aktifleştir";
            this.btnActived.UseVisualStyleBackColor = true;
            this.btnActived.Click += new System.EventHandler(this.BtnActived_Click);
            // 
            // frmPassiveMember
            // 
            this.AcceptButton = this.btnActived;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btnActived);
            this.Controls.Add(this.lstPassiveMembers);
            this.Name = "frmPassiveMember";
            this.Text = "Aktif Olmayan Üyeler";
            this.Load += new System.EventHandler(this.FrmPassiveMember_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPassiveMembers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnActived;
    }
}