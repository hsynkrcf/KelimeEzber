using KelimeEzber.CustomException;
using KelimeEzber.DAL;
using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.BLL
{
    public class DictionaryBLL
    {
        public DictionaryDAL _dictDal;

        public DictionaryBLL()
        {
            _dictDal = new DictionaryDAL();
        }
        void CheckFields(MyDictionary dict)
        {
            if (string.IsNullOrWhiteSpace(dict.TurkishWord))
            {
                throw new NotNullException("EMail");
            }
            else if (string.IsNullOrWhiteSpace(dict.EnglishWord))
            {
                throw new NotNullException("Şifre");
            }
        }
        public bool Add(MyDictionary dictionary)
        {
            CheckFields(dictionary);
            CheckWords(dictionary);
            int affectedRows = _dictDal.Add(dictionary);
            return affectedRows > 0;
        }

        private void CheckWords(MyDictionary dictionary)
        {
            List<MyDictionary> words = GetAllWords();
            foreach (MyDictionary item in words)
            {
                if (item.TurkishWord.ToLower() == dictionary.TurkishWord.ToLower() && item.EnglishWord.ToLower() == dictionary.EnglishWord.ToLower())
                {
                    throw new WordException();
                }
            }
        }

        public bool Update(MyDictionary dictionary)
        {
            int affectedRows = _dictDal.Update(dictionary);
            return affectedRows > 0;
        }

        public bool Delete(int wordID)
        {
            int affectedRows = _dictDal.Delete(wordID);
            return affectedRows > 0;
        }

        public MyDictionary GetWordByID(int wordID)
        {
            return _dictDal.GetWordByID(wordID);
        }

        public List<MyDictionary> GetAllWords()
        {
            return _dictDal.GetAllWords();
        }

        public int CountWordByPoolID(int wordID, string first, string last)
        {
            return _dictDal.CountWordByPoolID(wordID,first,last);
        }

    }
}
