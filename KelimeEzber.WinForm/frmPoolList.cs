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
	public partial class frmPoolList : Form
	{
        User _currentUser;
        List<Pool> currentPools;
        PoolBLL _poolBLL;
        ExerciseBLL _exerciseBLL;
        ListViewItem lvi;

        public frmPoolList(User user)
		{
			InitializeComponent();
            _currentUser = user;
            _poolBLL = new PoolBLL();
            _exerciseBLL = new ExerciseBLL();
		}
        void RefreshList()
        {
            lvPools.Items.Clear();
            currentPools = _poolBLL.GetAllPoolsByID(_currentUser.UserID);
            foreach (Pool item in currentPools)
            {
                Exercise myex = _exerciseBLL.GetExerciseByID(item.ExerciseID);
                lvi = new ListViewItem(item.PoolName);
                lvi.SubItems.Add(myex.ExerciseType);
                lvi.Tag = item.PoolID;
                lvPools.Items.Add(lvi);
            }
        }
        private void FrmPoolList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void BtnOpenPool_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvPools.FocusedItem;

            if(lvi != null)
            {
                frmExerciseScene frmExerciseScene = new frmExerciseScene(_currentUser, (int)lvi.Tag);
                frmExerciseScene.MdiParent = this.MdiParent;
                frmExerciseScene.Show();
                this.Close();
            }
        }

        private void BtnDeletePool_Click(object sender, EventArgs e)
        {
            if (lvi != null)
            {
                _poolBLL.Update((int)lvPools.SelectedItems[0].Tag);
            }
            RefreshList();
            if (lvPools.Items.Count == 0)
            {
                btnDeletePool.Enabled = false;
            }
        }

        private void LvPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePool.Enabled = true;
        }
    }
}
