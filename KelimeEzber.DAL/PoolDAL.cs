using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class PoolDAL
    {
        Helper helper;

        public PoolDAL()
        {
            helper = new Helper();
        }

        public int Add(Pool deadpool)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string query = @"INSERT INTO Pool(ExerciseID,UserID,PoolName,CreatedDate,IsActive) 
								VALUES(@exerciseID,@userID, @poolName, @createdDate, @isActive)";
            parameters.Add(new SqlParameter("@exerciseID", deadpool.ExerciseID));
            parameters.Add(new SqlParameter("@userID", deadpool.UserID));
            parameters.Add(new SqlParameter("@poolName", deadpool.PoolName));
            parameters.Add(new SqlParameter("@createdDate", deadpool.CreatedDate));
            parameters.Add(new SqlParameter("@isActive", deadpool.IsActive));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }
        public int Update(int poolID)
        {
            string query = "UPDATE Pool SET IsActive = @isActive WHERE PoolID = @poolID";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@poolID", poolID));
            parameters.Add(new SqlParameter("@isActive", false));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }
        public int Update(Pool deadpool)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string query = "UPDATE Pool SET ExerciseID = @exerciseID, UserID = @userID, PoolName = @poolName, CreatedDate = @createdDate WHERE PoolID = @poolID";
            parameters.Add(new SqlParameter("@poolID", deadpool.PoolID));
            parameters.Add(new SqlParameter("@exerciseID", deadpool.ExerciseID));
            parameters.Add(new SqlParameter("@userID", deadpool.UserID));
            parameters.Add(new SqlParameter("@poolName", deadpool.PoolName));
            parameters.Add(new SqlParameter("@createdDate", deadpool.CreatedDate));
            parameters.Add(new SqlParameter("@isActive", deadpool.IsActive));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        public int Delete(Pool deadpool)
        {
            Pool currentPool = deadpool;
            currentPool.IsActive = false;
            return Update(currentPool);
        }

        public Pool GetPoolByID(int poolID)
        {
            Pool deadpool = new Pool();
            string query = "SELECT * FROM Pool WHERE PoolID = @poolID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@poolID", poolID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            deadpool.PoolID = poolID;
            deadpool.ExerciseID = reader.GetInt32(1);
            deadpool.UserID = reader.GetInt32(2);
            deadpool.PoolName = reader.GetString(3);
            deadpool.CreatedDate = reader.GetDateTime(4);
            deadpool.IsActive = reader.GetBoolean(5);
			reader.Close();
            return deadpool;
        }
        
        public List<Pool> NonActivePools()
        {
            List<Pool> listRole = new List<Pool>();
            Pool deadpool = null;
            string query = "SELECT * FROM Pool WHERE IsActive = @isActive";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@isActive", false) });
            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                deadpool = new Pool();
                deadpool.PoolID = reader.GetInt16(0);
                deadpool.ExerciseID = reader.GetInt16(1);
                deadpool.UserID = reader.GetInt16(2);
                deadpool.PoolName = reader.GetString(3);
                deadpool.CreatedDate = reader.GetDateTime(4);
                deadpool.IsActive = reader.GetBoolean(5);
                listRole.Add(deadpool);
            }
            reader.Close();
            return listRole;
        }
        public List<Pool> GetAllPools()
        {
            List<Pool> listPool = new List<Pool>();
            Pool deadpool = null;
            string query = "SELECT * FROM Pool";

            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                deadpool = new Pool();
                deadpool.PoolID = reader.GetInt16(0);
                deadpool.ExerciseID = reader.GetInt16(1);
                deadpool.UserID = reader.GetInt16(2);
                deadpool.PoolName = reader.GetString(3);
                deadpool.CreatedDate = reader.GetDateTime(4);
                deadpool.IsActive = reader.GetBoolean(5);
                listPool.Add(deadpool);
            }
            reader.Close();

            return listPool;
        }

        public List<Pool> GetAllPools(int userID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            List<Pool> listPool = new List<Pool>();
            Pool deadpool = null;
            string query = "SELECT * FROM Pool WHERE UserID = @userID AND IsActive = @isactive";
            parameters.Add(new SqlParameter("@userID", userID));
            parameters.Add(new SqlParameter("@isactive", true));
            helper.AddParameters(parameters);
            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                deadpool = new Pool();
                deadpool.PoolID = reader.GetInt32(0);
                deadpool.ExerciseID = reader.GetInt32(1);
                deadpool.UserID = reader.GetInt32(2);
                deadpool.PoolName = reader.GetString(3);
                deadpool.CreatedDate = reader.GetDateTime(4);
                deadpool.IsActive = reader.GetBoolean(5);
                listPool.Add(deadpool);
            }
            reader.Close();

            return listPool;
        }

        public int GetPoolCountByID(int userID)
        {
            string query = "SELECT COUNT(PoolID) FROM [Pool] WHERE UserID = @userID AND IsActive = 1";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@userID", userID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();
            return count;
        }

        public List<int> GetWordByPoolID(int poolID)
        {
            List<int> wordID = new List<int>();
            string query = "SELECT WordID FROM DictionaryPool WHERE PoolID = @poolID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@poolID", poolID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                wordID.Add(reader.GetInt32(0));
            }
            reader.Close();
            return wordID;
        }

        public List<Pool> GetPoolByExerciseID(int exerciseID,int userID)
        {
            Pool pool = null;
            List<Pool> pools = new List<Pool>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            string query = "SELECT * FROM Pool WHERE ExerciseID = @exerciseID AND IsActive = 1 AND UserID = @userID";
            parameters.Add(new SqlParameter("@exerciseID", exerciseID));
            parameters.Add(new SqlParameter("@userID", userID));
            helper.AddParameters(parameters);

            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                pool = new Pool();
                pool.PoolID = reader.GetInt32(0);
                pool.ExerciseID = reader.GetInt32(1);
                pool.UserID = reader.GetInt32(2);
                pool.PoolName = reader.GetString(3);
                pool.CreatedDate = reader.GetDateTime(4);
                pool.IsActive = reader.GetBoolean(5);
                pools.Add(pool);
            }
            reader.Close();
            return pools;
        }

        public int AddWordPool(int poolID, int wordID)
        {
            string query = "INSERT INTO DictionaryPool VALUES (@poolID, @wordID)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@poolID", poolID));
            parameters.Add(new SqlParameter("@wordID", wordID));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        public int DeleteWordPool(int poolID, int wordID)
        {
            string query = "DELETE FROM DictionaryPool WHERE WordID = @wordID AND PoolID = @poolID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@poolID", poolID));
            parameters.Add(new SqlParameter("@wordID", wordID));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        public int GetLastPool()
        {
            int poolID = 0;
            string query = "SELECT TOP 1 * FROM Pool ORDER BY PoolID DESC";            
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            poolID = reader.GetInt32(0);            
            reader.Close();
            return poolID;
        }

		public int CountAddedWordsByUserID(int userID,string first, string last)
        {
            string query = "SELECT COUNT(*) FROM Pool p JOIN DictionaryPool dp ON dp.PoolID = p.PoolID  WHERE(CONVERT(VARCHAR(10), CreatedDate, 121) BETWEEN @firstDate AND @lastDate) AND UserID = @userID";
            int count = TariheGöre(query,userID, first, last);
            return count;
        }

        private int TariheGöre(string query,int userID, string first, string last)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userID", userID));
            parameters.Add(new SqlParameter("@firstDate", first));
            parameters.Add(new SqlParameter("@lastDate", last));
            helper.AddParameters(parameters);
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();
            return count;
        }

        public int CountExercisesByUserID(int userID,string first,string last)
		{
			string query = "SELECT COUNT(*) FROM Pool WHERE(CONVERT(VARCHAR(10), CreatedDate, 121) BETWEEN @firstDate AND @lastDate) AND UserID = @userID";
            int count = TariheGöre(query, userID, first, last);
            return count;
        }
    }
}
