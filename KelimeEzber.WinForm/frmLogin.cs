using KelimeEzber.BLL;
using KelimeEzber.DTO;
using KelimeEzber.WinForm.Classes;
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
    public partial class frmLogin : Form
    {
        UserBLL _userBLL;
        LoginDTO login;
        LoginHelper helper;

        public frmLogin()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            helper = new LoginHelper();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userID = 0;
            login = new LoginDTO();
            login.Mail = txtMail.Text;
            login.Password = txtPassword.Text;
            string result = _userBLL.Login(login);
            
            if (int.TryParse(result, out userID))
            {
                if (userID == 1)
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.Owner = this;
                    frmAdmin.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        _userBLL.IsUserPassive(userID);
                        frmMain frmMain = new frmMain(userID);
                        frmMain.Owner = this;
                        frmMain.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                rememberMe();
            }
            else if(string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void rememberMe()
        {
            if (chkRememberMe.Checked)
            {
                helper.Create(login);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void LblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Owner = this;
            frmRegister.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           login = helper.Read("EzberBozanlar.daho");
           txtMail.Text = login.Mail;
           txtPassword.Text = login.Password;
           chkRememberMe.Checked = true;
        }

        private void Clear()
        {
            if (!chkRememberMe.Checked)
            {
                txtMail.Clear();
                txtPassword.Clear();
            }
        }

        private void FrmLogin_VisibleChanged(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
