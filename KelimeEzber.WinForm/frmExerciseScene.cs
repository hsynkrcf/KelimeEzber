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
    public partial class frmExerciseScene : Form
    {
        User _currentUser;
        Pool _currentPool;
        PoolBLL _poolBLL;
        ExerciseBLL _exerciseBLL;
        DictionaryBLL _dictBLL;
        List<MyDictionary> words;
        Exercise exercise;
        int[] results;
        int index;
        public frmExerciseScene(User user, int poolID)
        {
            InitializeComponent();
            _poolBLL = new PoolBLL();
            _exerciseBLL = new ExerciseBLL();
            _dictBLL = new DictionaryBLL();
            _currentUser = user;
            _currentPool = _poolBLL.GetPool(poolID);
            index = 0;
            results = new int[3];
            words = new List<MyDictionary>();
        }

        void PlayGame()
        {
            exercise = _exerciseBLL.GetExerciseByID(_currentPool.ExerciseID);
            GetWordsByID();

            if (exercise.ExerciseID == 1)
            {
                lblExerciseType.Text = "Kelimelerin Türkçe karşılığını bulunuz.";
                lblWord.Text = words[index].EnglishWord;
            }
            else if (exercise.ExerciseID == 2)
            {
                lblExerciseType.Text = "Kelimelerin İngilizce karşılığını bulunuz.";
                lblWord.Text = words[index].TurkishWord;
            }
            else if (exercise.ExerciseID == 3)
            {
                lblExerciseType.Text = "Karışık verilen kelimenin İngilizce karşılığını bulunuz.";
                lblWord.Text = Shuffle(words[index].EnglishWord);
            }
        }

        private void FrmExerciseScene_Load(object sender, EventArgs e)
        {
            PlayGame();
        }

        void GetWordsByID()
        {
            List<int> wordID = _poolBLL.GetWordByPoolID(_currentPool.PoolID);
            foreach (int item in wordID)
            {
                words.Add(_dictBLL.GetWordByID(item));
            }
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            btnControl.Enabled = false;
            btnNextWord.Enabled = true;
        }

        private void CheckAnswer()
        {
            if (exercise.ExerciseID == 1)
            {
                CheckWord(words[index].TurkishWord.ToLower());
            }
            else if (exercise.ExerciseID == 2)
            {
                CheckWord(words[index].EnglishWord.ToLower());
            }
            else if (exercise.ExerciseID == 3)
            {
                CheckWord(words[index].EnglishWord.ToLower());
            }

            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                results[2]++;
            }
        }

        void CheckWord(string checkedWord)
        {
            if (txtAnswer.Text.ToLower() == checkedWord.ToLower())
            {
                results[0]++;
                pbTrue.Visible = true;
            }
            else
            {
                results[1]++;
                pbWrong.Visible = true;
            }
        }

        string Shuffle(string word)
        {
            int lenght = word.Length;
            string shuffledWord = string.Empty;
            Random rnd = new Random();
            List<int> randomIndex = new List<int>();
            bool flag = true;
            int random = 0;

            while (flag)
            {
                random = rnd.Next(lenght);
                if (randomIndex.Contains(random))
                {
                    flag = true;
                }
                else
                {
                    randomIndex.Add(random);
                }

                if (randomIndex.Count == word.Length)
                {
                    flag = false;
                }
            }

            foreach (int item in randomIndex)
            {
                shuffledWord += word[item];
            }
            return shuffledWord;
        }

        private void BtnNextWord_Click(object sender, EventArgs e)
        {
            pbTrue.Visible = false;
            pbWrong.Visible = false;

            if (index < words.Count - 1)
            {
                index++;
                if (exercise.ExerciseID == 3)
                {
                    lblWord.Text = Shuffle(words[index].EnglishWord);
                }
                else
                {
                    lblWord.Text = words[index].EnglishWord;
                }
                txtAnswer.Clear();
                btnControl.Enabled = true;
                btnNextWord.Enabled = false;
            }
            else
            {
                btnControl.Enabled = false;
                btnNextWord.Enabled = false;
            }
        }

        private void BtnExerciseOver_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Doğru sayısı: {results[0]}\nYanlış sayısı: {results[1]}\nBoş Sayısı: {results[2]}","Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
