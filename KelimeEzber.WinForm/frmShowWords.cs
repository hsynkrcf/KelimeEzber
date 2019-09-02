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
    public partial class frmShowWords : Form
    {
        DictionaryBLL _dictionaryBLL;

        public frmShowWords()
        {
            InitializeComponent();
            _dictionaryBLL = new DictionaryBLL();
        }
	
        private void frmShowWords_Load(object sender, EventArgs e)
        {
            FillList();
        }

        public void FillList()
        {
            lstAllWords.Items.Clear();
            List<MyDictionary> allWords = new List<MyDictionary>();
            allWords = _dictionaryBLL.GetAllWords();
            ListViewItem lvi;
            foreach (MyDictionary item in allWords)
            {
                lvi = new ListViewItem(item.EnglishWord);
                lvi.SubItems.Add(item.TurkishWord);
                lvi.Tag = item.WordID;
                lstAllWords.Items.Add(lvi);
            }
            //MessageBox.Show("Yenilendi");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAddWord frmAddWord = new frmAddWord();
            frmAddWord.ShowDialog();
            FillList();
        }
    }
}
