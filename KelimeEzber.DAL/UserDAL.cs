using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class UserDAL
    {
        Helper _helper;

        public UserDAL()
        {
            _helper = new Helper();
        }

        public int Add(User user)
        {
            string query = "INSERT INTO [User] (RoleID, FirstName, LastName, EMail, Password, BirthDate, IsActive, CreatedDate) VALUES(@roleID, @name, @surname, @mail, @pass, @birthDate, @isActive, @createdDate)";
            List<SqlParameter> parameters = GetParameters(user, false);

            _helper.AddParameters(parameters);
            return _helper.ExecuteQuery(query);
        }

        private List<SqlParameter> GetParameters(User user, bool isUpdate)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (isUpdate)
            {
                parameters.Add(new SqlParameter("@userID", user.UserID));
            }
            parameters.Add(new SqlParameter("@roleID", user.RoleID));
            parameters.Add(new SqlParameter("@name", user.FirstName));
            parameters.Add(new SqlParameter("@surname", user.LastName));
            parameters.Add(new SqlParameter("@mail", user.EMail));
            parameters.Add(new SqlParameter("@pass", user.Password));
            parameters.Add(new SqlParameter("@birthDate", user.BirthDate));
            parameters.Add(new SqlParameter("@isActive", user.IsActived));
            parameters.Add(new SqlParameter("@createdDate", user.CreatedDate));
            return parameters;
        }

        public int Update(User user)
        {
            string query = "UPDATE [User] SET RoleID = @roleID, FirstName = @name, LastName = @surname, Email = @mail, Password = @pass, BirthDate = @birthDate, IsActive = @isActive, CreatedDate = @createdDate WHERE UserID = @userID";

            List<SqlParameter> parameters = GetParameters(user, true);
            _helper.AddParameters(parameters);
            return _helper.ExecuteQuery(query);
        }

        public int UpdatePassword(User user)
        {
            string query = "UPDATE [User] SET Password = @pass WHERE UserID = @userID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@pass", user.Password));
            parameters.Add(new SqlParameter("@userID", user.UserID));
            _helper.AddParameters(parameters);
            return _helper.ExecuteQuery(query);
        }

        public int UpdateRolePremium(int userID)
        {
            string query = "UPDATE [User] SET RoleID = @roleID WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@userID", userID));
            parameters.Add(new SqlParameter("@roleID", 3));
            _helper.AddParameters(parameters);
            return _helper.ExecuteQuery(query);
        }

        public int Update(int userID)
        {
            string query = "UPDATE [User] SET IsActive = @isActive WHERE UserID = @userID";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@userID", userID));
            parameters.Add(new SqlParameter("@isActive", true));
            _helper.AddParameters(parameters);
            return _helper.ExecuteQuery(query);
        }

        public int Delete(int userID)
        {
            User user = GetUserByID(userID);
            user.IsActived = false;
            user.EMail = user.EMail + " (Silindi)";
            return Update(user);
        }

        public User GetUserByID(int userID)
        {
            string query = "SELECT * FROM [User] WHERE UserID = @userID";
            User user = new User();
            _helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@userID", userID) });
            SqlDataReader reader = _helper.ExecuteReader(query);
            reader.Read();
            user = GetUser(reader);
            reader.Close();
            return user;
        }

        private User GetUser(SqlDataReader reader)
        {
            User user = new User();
            user.UserID = reader.GetInt32(0);
            user.RoleID = reader.GetInt32(1);
            user.FirstName = reader.GetString(2);
            user.LastName = reader.GetString(3);
            user.EMail = reader.GetString(4);
            user.Password = reader.GetString(5);
            user.BirthDate = reader.GetDateTime(6);
            user.IsActived = reader.GetBoolean(7);
            user.CreatedDate = reader.GetDateTime(8);
            return user;
        }

        public List<User> GetAllPassiveUsers()
        {
            string query = "SELECT * FROM [User] WHERE IsActive = @isActive";
            List<User> users = new List<User>();
            _helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@isActive", false) });
            SqlDataReader reader = _helper.ExecuteReader(query);
            while (reader.Read())
            {
                users.Add(GetUser(reader));
            }
            reader.Close();
            return users;
        }

        public List<User> GetAllUsers()
        {
            string query = "SELECT * FROM [User]";
            List<User> users = new List<User>();
            SqlDataReader reader = _helper.ExecuteReader(query);
            while (reader.Read())
            {
                users.Add(GetUser(reader));
            }
            reader.Close();
            return users;
        }

        public User GetUserByMail(string mail)
        {
            string query = "SELECT * FROM [User] WHERE EMail = @mail";
            User user = null;
            _helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@mail", mail) });
            SqlDataReader reader = _helper.ExecuteReader(query);
            reader.Read();
            user = GetUser(reader);
            reader.Close();
            return user;
        }

        public int GetAllStandartUsers(string first, string last)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string query = "SELECT COUNT(*) FROM [User]WHERE(CONVERT(VARCHAR(10), CreatedDate, 121) BETWEEN @firstDate AND @lastDate) AND RoleID = 2";

            parameters.Add(new SqlParameter("firstDate", first));
            parameters.Add(new SqlParameter("lastDate", last));
            _helper.AddParameters(parameters);

            int sum = 0;
            SqlDataReader reader = _helper.ExecuteReader(query);
            reader.Read();
            sum = reader.GetInt32(0);
            reader.Close();
            return sum;
        }

        public User GetLastUser()
        {
            string query = "SELECT TOP 1 * FROM [User] ORDER BY UserID DESC";
            User user = null;
            SqlDataReader reader = _helper.ExecuteReader(query);
            reader.Read();
            user = GetUser(reader);
            reader.Close();
            return user;
        }
    }
}
