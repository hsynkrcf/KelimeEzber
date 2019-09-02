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
    public partial class frmProfileSettings : Form
    {
        User _currentUser;
        UserBLL _userBLL;

        public frmProfileSettings(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _userBLL = new UserBLL();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentUser.Password == txtPassword.Text)
                {
                    _currentUser.FirstName = txtName.Text;
                    _currentUser.LastName = txtSurname.Text;
                    _currentUser.EMail = txtMail.Text;
                    _userBLL.Update(_currentUser);
                }
                else
                {
                    MessageBox.Show("Hatalı şifre girdiniz");
                }

                MessageBox.Show("İşlem başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
