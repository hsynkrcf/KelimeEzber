using KelimeEzber.CustomException;
using KelimeEzber.DAL;
using KelimeEzber.DTO;
using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.BLL
{
    public class UserBLL
    {
        UserDAL _userDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
        }

        public bool Add(User user)
        {
            CheckMail(user.EMail);
            CheckPassword(user.Password);
            CheckFields(user);
            int affectedRows = _userDAL.Add(user);
            return affectedRows > 0;
        }

        public bool Update(User user)
        {
            CheckMail(user.EMail);
            CheckPassword(user.Password);
            CheckFields(user);
            int affectedRows = _userDAL.Update(user);
            return affectedRows > 0;
        }
        public bool UpdatePassword(User user)
        {
            CheckPassword(user.Password);
            CheckFields(user);
            int affectedRows = _userDAL.UpdatePassword(user);
            return affectedRows > 0;
        }
        public bool Update(int userID)
        {
            int affectedRows = _userDAL.Update(userID);
            return affectedRows > 0;
        }

        public bool Delete(int userID)
        {
            int affectedRows = _userDAL.Delete(userID);
            return affectedRows > 0;
        }
        public bool UpdatePremium(int userID)
        {
            int affectedRows = _userDAL.UpdateRolePremium(userID);
            return affectedRows > 0;
        }

        void CheckMail(string mail)
        {
            try
            {
                System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(mail);
            }
            catch
            {
                throw new MailFormatException();
            }

            List<User> users = _userDAL.GetAllUsers();
            foreach (User item in users)
            {
                if (item.EMail == mail)
                {
                    throw new SameData("mail adresi");
                }
            }
        }

        void CheckFields(User user)
        {
            if (string.IsNullOrWhiteSpace(user.EMail))
            {
                throw new NotNullException("EMail");
            }
            else if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new NotNullException("Şifre");
            }
            else if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                throw new NotNullException("İsim");
            }
            else if (string.IsNullOrWhiteSpace(user.LastName))
            {
                throw new NotNullException("Soyisim");
            }
        }

        void CheckPassword(string password)
        {
            if (password.Length < 8)
            {
                throw new PasswordLengthException();
            }
            int letterCount = 0;
            foreach (char item in password)
            {
                if (char.IsLetter(item))
                {
                    letterCount++;
                }
            }
            if (letterCount < 3)
            {
                throw new PasswordLetterCountException();
            }
        }

        public User GetUserByID(int userID)
        {
            return _userDAL.GetUserByID(userID);
        }

        public User GetUserByName(string mail)
        {
            return _userDAL.GetUserByMail(mail);
        }

        public List<User> GetAllPassiveUsers()
        {
            return _userDAL.GetAllPassiveUsers();
        }

        public int GetAllStandartUsers(string first, string last)
        {
            return _userDAL.GetAllStandartUsers(first,last);
        }

        public List<User> GetAllUsers()
        {
            return _userDAL.GetAllUsers();
        }

        public string Login(LoginDTO login)
        {
            List<User> users = _userDAL.GetAllUsers();
            foreach (User item in users)
            {
                if (item.EMail == login.Mail)
                {
                    if (item.Password == login.Password)
                    {
                        return item.UserID.ToString();
                    }
                    else
                    {
                        return "Şifre yanlış";
                    }
                }
            }
            return "Mail yanlış";
        }

        public void IsUserPassive(int userID)
        {
            List<User> passiveUsers = GetAllPassiveUsers();
            foreach (User item in passiveUsers)
            {
                if(item.UserID == userID)
                {
                    throw new PassiveUserException();
                }
            }
        }

        public User GetLastUser()
        {
            return _userDAL.GetLastUser();
        }
    }
}
