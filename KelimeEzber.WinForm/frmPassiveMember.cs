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
    public partial class frmPassiveMember : Form
    {
        UserBLL _userBLL;
        UserRoleBLL _roleBLL;
        public frmPassiveMember()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _roleBLL = new UserRoleBLL();
        }

        void Refresh()
        {
            lstPassiveMembers.Items.Clear();
            UserRole role;
            List<User> passiveUsers = new List<User>();
            passiveUsers = _userBLL.GetAllPassiveUsers();
            ListViewItem lvi;
            foreach (User item in passiveUsers)
            {
                role = _roleBLL.GetRole(item.RoleID);
                lvi = new ListViewItem(role.RoleName);
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.EMail);
                lvi.SubItems.Add(item.BirthDate.ToShortDateString());
                lvi.SubItems.Add(item.CreatedDate.ToShortDateString());
                lvi.Tag = item.UserID;
                lstPassiveMembers.Items.Add(lvi);
            }
        }

        private void FrmPassiveMember_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnActived_Click(object sender, EventArgs e)
        {
            User currentUser = _userBLL.GetUserByID((int)lstPassiveMembers.SelectedItems[0].Tag);
            if (_userBLL.Update(currentUser.UserID))
            {
                MessageBox.Show("Kullanıcı Başarıyla Onaylandı");
            }
            else
            {
                MessageBox.Show("Kullanıcı Onayı Başarısız");
            }
            Refresh();
        }
    }
}
