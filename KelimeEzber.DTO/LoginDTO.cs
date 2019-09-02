using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DTO
{
    [Serializable]
    public class LoginDTO
    {
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}

