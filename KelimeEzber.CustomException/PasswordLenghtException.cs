using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class PasswordLengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifre en az 8 karakter olmalıdır";
            }
        }
    }
}
