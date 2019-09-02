using KelimeEzber.BLL;
using KelimeEzber.Entities;
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
	public partial class frmMain : Form
	{

        User _currentUser;
        UserBLL _userBLL;
		public frmMain(int userID)
		{
			InitializeComponent();
            _userBLL = new UserBLL();
            _currentUser = _userBLL.GetUserByID(userID);
		}

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            frmLogin frmLogin = this.Owner as frmLogin;
            frmLogin.Show();
        }

        private void YeniHavuzOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPool frmNewPool = new frmNewPool(_currentUser);
            frmNewPool.MdiParent = this;
            frmNewPool.Show();
        }

        private void HavuzlarımıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoolList frmPoolList = new frmPoolList(_currentUser);
            frmPoolList.MdiParent = this;
            frmPoolList.Show();
        }

        private void KelimeTransferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferWord frmTransferWord = new frmTransferWord(_currentUser);
            frmTransferWord.MdiParent = this;
            frmTransferWord.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (_currentUser.RoleID == 2)
            {
                kelimeTransferiToolStripMenuItem.Enabled = false;
                lblGetPay.Visible = true;
            }
        }


        private void LblGetPay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPayment _frmPayment = new frmPayment();
            _frmPayment.Owner = this;
            _frmPayment.ShowDialog();
            if (_frmPayment.flag)
            {
                _userBLL.UpdatePremium(_currentUser.UserID);
                MessageBox.Show("Premium Özelliklerini Kullanabilmeniz İçin Tekrar Giriş Yapınız.");
                this.Close();
            }
        }

        private void ProfilBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfileSettings frmProfileSettings = new frmProfileSettings(_currentUser);
            frmProfileSettings.MdiParent = this;
            frmProfileSettings.Show();
        }

        private void ŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(_currentUser);
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();
        }
    }
}
