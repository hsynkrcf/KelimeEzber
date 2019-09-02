using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KelimeEzber.BLL;
using KelimeEzber.Entities;

namespace KelimeEzber.WinForm
{
    public partial class frmAllMember : Form
    {
		UserBLL _userBLL;
		UserRoleBLL _roleBLL;

		public frmAllMember()
        {
            InitializeComponent();
			_userBLL = new UserBLL();
			_roleBLL = new UserRoleBLL();
		}

		private void frmAllMember_Load(object sender, EventArgs e)
		{
			lstAllMember.Items.Clear();
			UserRole role;
			List<User> allUsers = new List<User>();
			allUsers = _userBLL.GetAllUsers();
			ListViewItem lvi;
			foreach (User item in allUsers)
			{
				if (item.RoleID != 1)
				{
					role = _roleBLL.GetRole(item.RoleID);
					lvi = new ListViewItem(role.RoleName);
					lvi.SubItems.Add(item.FirstName);
					lvi.SubItems.Add(item.LastName);
					lvi.SubItems.Add(item.EMail);
					lvi.SubItems.Add(item.BirthDate.ToShortDateString());
					lvi.SubItems.Add(item.IsActived ? "Aktif" : "Pasif");
					lvi.SubItems.Add(item.CreatedDate.ToShortDateString());
					lvi.Tag = item.UserID;
					lstAllMember.Items.Add(lvi); 
				}
			}
		}
	}
}
