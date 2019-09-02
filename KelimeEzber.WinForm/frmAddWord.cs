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
    public partial class frmAddWord : Form
    {
        public event RefreshList RefreshList;
        DictionaryBLL _dictBLL;

        public frmAddWord()
        {
            InitializeComponent();
            _dictBLL = new DictionaryBLL();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MyDictionary myDict = new MyDictionary();

                myDict.TurkishWord = txtTurkish.Text;
                myDict.EnglishWord = txtEnglish.Text;
                _dictBLL.Add(myDict);
                //RefreshList();

                MessageBox.Show("Sözcük Eklendi");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAddWord_Load(object sender, EventArgs e)
        {
            txtEnglish.Clear();
            txtTurkish.Clear();
        }
    }
}
