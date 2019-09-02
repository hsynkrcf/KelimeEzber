using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class DictionaryDAL
    {
        Helper helper;

        public DictionaryDAL()
        {
            helper = new Helper();
        }

        public int Add(MyDictionary dictionary)
        {
            string query = "INSERT INTO Dictionary (Turkish, English) VALUES (@turkishWord, @englishWord)";
            List<SqlParameter> parameters = GetParameters(dictionary, false);
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        private List<SqlParameter> GetParameters(MyDictionary dictionary, bool isUpdate)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@turkishWord", dictionary.TurkishWord));
            parameters.Add(new SqlParameter("@englishWord", dictionary.EnglishWord));
            if (isUpdate)
            {
                parameters.Add(new SqlParameter("@WordID", dictionary.WordID));
            }
            return parameters;
        }

        public int Update(MyDictionary dictionary)
        {
            string query = "UPDATE Dictionary SET Turkish = @turkishWord, English = @englishWord WHERE WordID = @wordID";
            List<SqlParameter> parameters = GetParameters(dictionary, true);
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        public int Delete(int wordID)
        {
            string query = "DELETE FROM Dictionary WHERE WordID = @wordID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@wordID", wordID) });
            return helper.ExecuteQuery(query);
        }

        public MyDictionary GetWordByID(int wordID)
        {
            string query = "SELECT * FROM Dictionary WHERE WordID = @wordID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@wordID", wordID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            MyDictionary word = GetWord(reader);
            reader.Close();
            return word;
        }

        private MyDictionary GetWord(SqlDataReader reader)
        {
            MyDictionary dict = new MyDictionary();
            dict.WordID = reader.GetInt32(0);
            dict.TurkishWord = reader.GetString(1);
            dict.EnglishWord = reader.GetString(2);
            return dict;
        }

        public List<MyDictionary> GetAllWords()
        {
            List<MyDictionary> dictionary = new List<MyDictionary>();
            string query = "SELECT * FROM Dictionary";
            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                dictionary.Add(GetWord(reader));
            }
            reader.Close();
            return dictionary;
        }

		public int CountWordByPoolID(int wordID,string first,string last)
		{
            List<SqlParameter> parameters = new List<SqlParameter>();
			string query = "SELECT COUNT(*) FROM DictionaryPool dc JOIN Pool p ON P.PoolID = dc.PoolID  WHERE(CONVERT(VARCHAR(10), CreatedDate, 121) BETWEEN @firstDate AND @lastDate) AND WordID = @wordID";
			parameters.Add(new SqlParameter("@wordID", wordID));
			parameters.Add(new SqlParameter("@firstDate", first));
			parameters.Add(new SqlParameter("@lastDate", last));
            helper.AddParameters(parameters);

			SqlDataReader reader = helper.ExecuteReader(query);
			reader.Read();
			int count = reader.GetInt32(0);
			reader.Close();
			return count;
		}
    }
}
