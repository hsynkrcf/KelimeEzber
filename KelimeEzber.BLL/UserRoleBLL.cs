using KelimeEzber.DAL;
using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.BLL
{
    public class UserRoleBLL
    {        
        UserRoleDAL _userRoleController;

        public UserRoleBLL()
        {
            _userRoleController = new UserRoleDAL();
        }
        public bool Add(UserRole role)
        {
            int result = _userRoleController.Add(role);
            return result > 0;
        }
        public bool Update(UserRole role)
        {
            int result = _userRoleController.Update(role);
            return result > 0;
        }
        public bool Delete(UserRole role) 
        {
            int result = _userRoleController.Delete(role);
            return result > 0;
        }
        public UserRole GetRole(int RoleID)
        {
            return _userRoleController.GetRoleByID(RoleID);
        }
        public List<UserRole> GetRoles()
        {
            return _userRoleController.GetAllRole();
        }
    }
}
