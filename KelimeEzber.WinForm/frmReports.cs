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
	public partial class frmReports : Form
	{
		PaymentBLL _paymentBLL;
		UserBLL _userBLL;
		UserRoleBLL _roleBLL;
		DictionaryBLL _dictionaryBLL;
		PoolBLL _poolBLL;
        string firstDate, lastDate;

        public frmReports(int report)
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _roleBLL = new UserRoleBLL();
            _dictionaryBLL = new DictionaryBLL();
            _paymentBLL = new PaymentBLL();
            _poolBLL = new PoolBLL();
            if (report == 1)
            {
                lastDate = DateTime.Now.ToString("yyyy-MM-dd");
                firstDate = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
            }
            else if (report == 2)
            {
                lastDate = DateTime.Now.ToString("yyyy-MM-dd");
                firstDate = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            }
            else
            {
                firstDate = dtpStartDate.Value.ToShortDateString();
                lastDate = dtpEndDate.Value.ToShortDateString();
                groupDate.Visible = true;
            }
        }

		private void frmReports_Load(object sender, EventArgs e)
		{
			lstUsers.Items.Clear();
			List<User> allUsers = new List<User>();
			allUsers = _userBLL.GetAllUsers();
			ListViewItem lviUsers;
			foreach (User item in allUsers)
			{
				if (item.RoleID != 1)
				{
					lviUsers = new ListViewItem(item.FirstName + " " + item.LastName);
					lviUsers.Tag = item.UserID;
					lstUsers.Items.Add(lviUsers);
				}
			}

			lviAllWords.Items.Clear();
			List<MyDictionary> allWords = new List<MyDictionary>();
			allWords = _dictionaryBLL.GetAllWords();
			ListViewItem lviWords;
			foreach (MyDictionary item in allWords)
			{
				lviWords = new ListViewItem(item.EnglishWord + " - " + item.TurkishWord);
				lviWords.Tag = item.WordID;
				lviAllWords.Items.Add(lviWords);
			}
		}

		private void btnRevenue_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_paymentBLL.GetAllPaymentsByDates(firstDate,lastDate).ToString());
		}

		private void btnHowManyWord_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = lstUsers.FocusedItem;
			if (lvi != null)
			{
				MessageBox.Show(_poolBLL.CountAddedWordsByUserID((int)lvi.Tag,firstDate, lastDate).ToString());
			}
		}

		private void btnHowManyPool_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = lviAllWords.FocusedItem;
			if (lvi != null)
			{
				int count = _dictionaryBLL.CountWordByPoolID((int)lvi.Tag,firstDate,lastDate);
				MessageBox.Show(count.ToString());
			}
		}

		private void btnHowManyExercise_Click(object sender, EventArgs e)
		{
			ListViewItem lvi = lstUsers.FocusedItem;
			if (lvi != null)
			{
				MessageBox.Show(_poolBLL.CountExercisesByUserID((int)lvi.Tag,firstDate,lastDate).ToString());
			}
		}

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lastDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void BtnStandartMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_userBLL.GetAllStandartUsers(firstDate, lastDate).ToString());
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            firstDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }
    }
}
