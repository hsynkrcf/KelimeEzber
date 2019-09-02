using KelimeEzber.BLL;
using KelimeEzber.Entities;
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
using static System.Windows.Forms.ListView;

namespace KelimeEzber.WinForm
{
    public partial class frmTransferWord : Form
    {
        User currentUser;
        PoolBLL _poolBLL;
        List<int> wordIDList;
        DictionaryBLL _dictBLL;
        Pool focusedPool, selectedPool;
        public frmTransferWord(User user)
        {
            InitializeComponent();
            currentUser = user;
            _poolBLL = new PoolBLL();
            wordIDList = new List<int>();
            _dictBLL = new DictionaryBLL();
        }

        private void FrmTransferWord_Load(object sender, EventArgs e)
        {
            cmbFirstPool.SelectedIndexChanged -= CmbFirstPool_SelectedIndexChanged;
            cmbFirstPool.DataSource = _poolBLL.GetAllPoolsByID(currentUser.UserID);
            cmbFirstPool.SelectedIndex = -1;
            cmbFirstPool.SelectedIndexChanged += CmbFirstPool_SelectedIndexChanged;
        }

        private void CmbFirstPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedPool = (Pool)cmb.SelectedValue;
            FillTheListByID(selectedPool, lstFirstPool);

            List<Pool> pools = _poolBLL.GetPoolByExerciseID(selectedPool.ExerciseID, currentUser.UserID);
            cmbSecondPool.SelectedIndexChanged -= CmbSecondPool_SelectedIndexChanged;
            cmbSecondPool.DataSource = pools;
            cmbSecondPool.SelectedIndex = -1;
            cmbSecondPool.SelectedIndexChanged += CmbSecondPool_SelectedIndexChanged;

        }

        private void CmbSecondPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            focusedPool = cmbSecondPool.SelectedValue as Pool;
        }

        public void FillTheListByID(Pool myPool, ListView lst)
        {
            List<MyDictionary> words = new List<MyDictionary>();
            wordIDList = _poolBLL.GetWordByPoolID(myPool.PoolID);
            ListViewItem lvi;
            lst.Items.Clear();

            if (wordIDList.Count > 0)
            {
                foreach (int item in wordIDList)
                {
                    words.Add(_dictBLL.GetWordByID(item));
                }
            }
            else
            {
                words.Clear();
            }

            foreach (MyDictionary item in words)
            {
                if (myPool.ExerciseID == 2)
                {
                    lvi = new ListViewItem(item.TurkishWord);
                    lvi.Tag = item.WordID;
                    lst.Items.Add(lvi);
                }
                else if (myPool.ExerciseID == 1 || myPool.ExerciseID == 3)
                {
                    lvi = new ListViewItem(item.EnglishWord);
                    lvi.Tag = item.WordID;
                    lst.Items.Add(lvi);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection lvi = lstFirstPool.SelectedItems;

            if (lvi != null && cmbSecondPool.SelectedIndex > -1)
            {

                if (selectedPool.PoolID != focusedPool.PoolID)
                {
                    foreach (ListViewItem item in lvi)
                    {
                        try
                        {
                            _poolBLL.AddWordPool(focusedPool.PoolID, (int)item.Tag);
                            _poolBLL.DeleteWordPool(selectedPool.PoolID, (int)item.Tag);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Aynı kelime eklenemez.");
                        }
                    }
                    FillTheListByID(selectedPool, lstFirstPool);
                }
                else
                {
                    MessageBox.Show("Aynı havuza transfer yapılamaz.");
                }

            }
            else if (lvi == null)
            {
                MessageBox.Show("Kelime seçmediniz!");
            }
            else
            {
                MessageBox.Show("Havuz seçmediniz");
            }
        }
    }
}
