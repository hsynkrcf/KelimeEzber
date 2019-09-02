using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActived { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
