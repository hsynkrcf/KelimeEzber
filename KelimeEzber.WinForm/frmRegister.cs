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
    public partial class frmRegister : Form
    {
        UserBLL _userBLL;
        User last;
        User _user;
        frmPayment _frmPayment;
        public frmRegister()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _user = new User();
        }

        private void LblStandart_Click(object sender, EventArgs e)
        {
            radioStandart.Checked = true;
        }

        private void LblPremium_Click(object sender, EventArgs e)
        {
            radioPremium.Checked = true;
        }

        private void PassHide1_CheckedChanged(object sender, EventArgs e)
        {
            if (PassHide1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void PassHide2_CheckedChanged(object sender, EventArgs e)
        {
            if (PassHide2.Checked)
            {
                txtPassControl.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassControl.UseSystemPasswordChar = true;
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            _frmPayment = new frmPayment();

            if (radioStandart.Checked || !_frmPayment.flag)
            {
                _user.RoleID = 2;
            }

            if (txtPass.Text == txtPassControl.Text)
            {
                try
                {
                    _user.FirstName = txtFirstName.Text;
                    _user.LastName = txtLastName.Text;
                    _user.EMail = txtEmail.Text;
                    _user.Password = txtPass.Text;
                    _user.BirthDate = dtpBirthDate.Value;
                    _userBLL.Add(_user);
                     last = _userBLL.GetLastUser();
                    if (radioPremium.Checked)
                    {
                        _frmPayment.Owner = this;
                        _frmPayment.ShowDialog();
                        if (_frmPayment.flag)
                        {
                            _userBLL.UpdatePremium(last.UserID);
                            GetPay(_frmPayment._payment);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            radioStandart.Checked = true;
            radioPremium.Checked = false;
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        void GetPay(Payment pay)
        {
            PaymentBLL paymentBLL = new PaymentBLL();
            pay.UserID = last.UserID;
            paymentBLL.Add(pay);
        }
    }
}
