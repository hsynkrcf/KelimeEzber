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
    public class PoolBLL
    {
        PoolDAL _poolDAL;
        UserDAL _userDAL;
        public PoolBLL()
        {
            _poolDAL = new PoolDAL();
            _userDAL = new UserDAL();
        }

        public bool Add(Pool pool)
        {
            CheckFields(pool);
            CheckPoolName(pool.UserID, pool.PoolName);

            User currentUser = _userDAL.GetUserByID(pool.UserID);

            if (currentUser.RoleID == 2)
            {
                int count = _poolDAL.GetPoolCountByID(pool.UserID);
                if (count == 1)
                {
                    throw new OverPoolException();
                }
            }
            int result = _poolDAL.Add(pool);
            return result > 0;
        }

        public bool Update(Pool pool)
        {
            int result = _poolDAL.Update(pool);
            return result > 0;
        }
        public bool Update(int userID)
        {
            int result = _poolDAL.Update(userID);
            return result > 0;
        }

        public bool Delete(Pool pool)
        {
            int affectedRows = _poolDAL.Delete(pool);
            return affectedRows > 0;
        }

        public Pool GetPool(int poolID)
        {
            return _poolDAL.GetPoolByID(poolID);
        }

        public List<Pool> GetAllPool()
        {
            return _poolDAL.GetAllPools();
        }

        public List<Pool> GetAllPoolsByID(int userID)
        {
            return _poolDAL.GetAllPools(userID);
        }

        public List<Pool> GetNonActivePools()
        {
            return _poolDAL.NonActivePools();
        }

        public List<int> GetWordByPoolID(int poolID)
        {
            return _poolDAL.GetWordByPoolID(poolID);
        }

        public List<Pool> GetPoolByExerciseID(int exerciseID,int userID)
        {
            return _poolDAL.GetPoolByExerciseID(exerciseID,userID);
        }

        void CheckFields(Pool pool)
        {
            if (string.IsNullOrWhiteSpace(pool.PoolName))
            {
                throw new NotNullException("Havuz adı");
            }
        }

        void CheckPoolName(int userID, string poolName)
        {
            List<Pool> usersPool = GetAllPoolsByID(userID);
            foreach (Pool item in usersPool)
            {
                if (item.PoolName == poolName)
                {
                    throw new SameData("havuz ismi");
                }
            }
        }

        public bool AddWordPool(int poolID, int wordID)
        {
            int affectedRows = _poolDAL.AddWordPool(poolID, wordID);
            return affectedRows > 0;
        }

        public bool DeleteWordPool(int poolID, int wordID)
        {
            int affectedRows = _poolDAL.DeleteWordPool(poolID, wordID);
            return affectedRows > 0;
        }

        public int GetLastPoolID()
        {
            return _poolDAL.GetLastPool();
        }

		public int CountAddedWordsByUserID(int userID,string first,string last)
		{
			return _poolDAL.CountAddedWordsByUserID(userID,first,last);
		}

		public int CountExercisesByUserID(int userID,string first,string last)
		{
			return _poolDAL.CountExercisesByUserID(userID,first,last);
		}
	}
}
