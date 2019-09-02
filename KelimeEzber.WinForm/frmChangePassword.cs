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
    public partial class frmChangePassword : Form
    {
        User _currentUser;
        UserBLL _userBLL;
        public frmChangePassword(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userBLL = new UserBLL();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentUser.Password == txtPassword.Text)
                {
                    if ((!string.IsNullOrWhiteSpace(txtNewPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirm.Text)) && txtConfirm.Text == txtNewPassword.Text)
                    {
                        _currentUser.Password = txtNewPassword.Text;
                        _userBLL.UpdatePassword(_currentUser);
                        MessageBox.Show("İşlem başarılı");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Şifrenizi düzgün girmediniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else if (!cbPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
