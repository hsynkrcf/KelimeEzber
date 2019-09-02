using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzber.WinForm
{
    public partial class frmAdmin : Form
    {
        frmShowWords _frmShowWords;

        public frmAdmin()
        {
            InitializeComponent();
            GetWordList();
        }

        private void GetWordList()
        {
            
            
        }

		private void OnaylanmayanÜyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPassiveMember frmPassiveMember = new frmPassiveMember();
			frmPassiveMember.MdiParent = this;
			frmPassiveMember.Show();
		}

		private void TümÜyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAllMember frmAllMember = new frmAllMember();
			frmAllMember.MdiParent = this;
			frmAllMember.Show();
		}

        //private void KelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmAddWord frmAddWord = new frmAddWord();
        //    frmAddWord.MdiParent = this;
        //    frmAddWord.Show();
        //    frmAddWord.RefreshList += _frmShowWords.FillList;
        //}

		private void kelimeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
		{
            _frmShowWords = new frmShowWords();
            _frmShowWords.MdiParent = this;
            _frmShowWords.Show();
        }

		private void raporToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForms();
            frmLogin frmLogin = this.Owner as frmLogin;
            frmLogin.Show();
        }

        void CloseForms()
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CloseForms();
        }

        void OpenReports(int report)
        {
            frmReports frmReports = new frmReports(report);
            frmReports.MdiParent = this;
            frmReports.Show();
        }

        private void HaftalıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReports(1);
        }

        private void AylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReports(2);
        }

        private void İkiTarihArasıRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReports(3);
        }
    }
}

