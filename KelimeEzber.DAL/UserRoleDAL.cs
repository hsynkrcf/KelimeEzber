using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class UserRoleDAL
    {
        Helper helper;

        public UserRoleDAL()
        {
            helper = new Helper();
        }

        public int Add(UserRole role)
        {
            string query = "INSERT INTO UserRole(RoleName) VALUES('@roleName')";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@roleName", role.RoleName) });
            return helper.ExecuteQuery(query);
        }

        public int Update(UserRole role)
        {
            List<SqlParameter>parameters = new List<SqlParameter>();
            string query = "UPDATE UserRole SET RoleName = '@roleName' WHERE RoleID = @roleID";
            parameters.Add(new SqlParameter("@roleName", role.RoleName));
            parameters.Add(new SqlParameter("@roleID", role.RoleID));
            helper.AddParameters(parameters);
            return helper.ExecuteQuery(query);
        }

        public int Delete(UserRole role)
        {
            string query = "DELETE FROM UserRole WHERE RoleID = @roleID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@roleID", role.RoleID) });
            return helper.ExecuteQuery(query);
        }

        public UserRole GetRoleByID(int RoleID)
        {
            UserRole role = new UserRole();
            string query = "SELECT * FROM UserRole WHERE RoleID = @roleID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@roleID", RoleID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            role.RoleID = RoleID;
            role.RoleName = reader["RoleName"].ToString();
			reader.Close();
            return role;
        }

        public List<UserRole> GetAllRole()
        {
            List<UserRole> listRole = new List<UserRole>();
            UserRole role = null;
            string query = "SELECT * FROM UserRole";

            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
				role = new UserRole();
                role.RoleID = reader.GetInt16(0);
                role.RoleName = reader.GetString(1);
                listRole.Add(role);
            }
            reader.Close();

            return listRole;
        }
    }
}
