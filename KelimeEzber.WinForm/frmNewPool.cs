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

namespace KelimeEzber.WinForm
{
	public partial class frmNewPool : Form
	{
        User _currentUser;
        List<MyDictionary> _allwords;
        List<Exercise> _allExercise;
        ExerciseBLL _exerciseBLL;
        DictionaryBLL _dictBLL;
        PoolBLL _poolBLL;
        Exercise _selectedExercise;
        public frmNewPool(User user)
		{
			InitializeComponent();
            _allwords = new List<MyDictionary>();
            _exerciseBLL = new ExerciseBLL();
            _dictBLL = new DictionaryBLL();
            _currentUser = user;
            _poolBLL = new PoolBLL();
        }

        private void FrmNewPool_Load(object sender, EventArgs e)
        {
            _allExercise = _exerciseBLL.GetAllExerciseByRole(_currentUser.RoleID);
            cmbExerciseType.SelectedIndexChanged -= CmbExerciseType_SelectedIndexChanged;
            cmbExerciseType.DataSource = _allExercise;
            cmbExerciseType.SelectedIndex = -1;
            cmbExerciseType.SelectedIndexChanged += CmbExerciseType_SelectedIndexChanged;
            _allwords = _dictBLL.GetAllWords();
        }

        private void CmbExerciseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUserWords.Items.Clear();
            _selectedExercise = (Exercise)cmbExerciseType.SelectedValue;
            if(_selectedExercise.ExerciseID == 1 || _selectedExercise.ExerciseID == 3)
            {
                GetEnglishWords();
            }
            else
            {
                GetTurkishWords();
            }
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lstAllWords.FocusedItem;

            if(lstUserWords.Items.Count == 10 && _currentUser.RoleID == 2)
            {
                MessageBox.Show("10'dan fazla kelime ekleyemezsiniz");                
            }

            if(lvi != null)
            {
                lstAllWords.Items.RemoveAt(lvi.Index);
                lstUserWords.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("Eleman seçmediniz");
            }

        }

        void GetEnglishWords()
        {
            lstAllWords.Items.Clear();
            ListViewItem lvi;
            foreach (MyDictionary item in _allwords)
            {
                lvi = new ListViewItem(item.EnglishWord);
                lvi.Tag = item.WordID;
                lstAllWords.Items.Add(lvi);
            }
        }
        void GetTurkishWords()
        {
            lstAllWords.Items.Clear();
            ListViewItem lvi;
            foreach (MyDictionary item in _allwords)
            {
                lvi = new ListViewItem(item.TurkishWord);
                lvi.Tag = item.WordID;
                lstAllWords.Items.Add(lvi);
            }
        }

        private void BtnCreatePool_Click(object sender, EventArgs e)
        {
            Pool createdPool = new Pool();
            try
            {
                if (cmbExerciseType.SelectedIndex > -1)
                {
                    createdPool.PoolName = txtPoolName.Text;
                    Exercise selectedExercise = (Exercise)cmbExerciseType.SelectedValue;
                    createdPool.ExerciseID = selectedExercise.ExerciseID;
                    createdPool.UserID = _currentUser.UserID;

                    _poolBLL.Add(createdPool);

                    foreach (ListViewItem item in lstUserWords.Items)
                    {
                        if (item != null)
                        {
                            createdPool.PoolID = _poolBLL.GetLastPoolID();
                            _poolBLL.AddWordPool(createdPool.PoolID,(int)item.Tag);
                        }
                    }
                    this.Close();
                    MessageBox.Show("Havuz Başarıyla Oluşturuldu");
                }
                else
                {
                    MessageBox.Show("Egzersiz türü seçmediniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void BtnRemoveWord_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lstUserWords.FocusedItem;
            if (lvi != null)
            {
                lstUserWords.Items.RemoveAt(lvi.Index);
                lstAllWords.Items.Add(lvi);
            }
        }
    }
}
