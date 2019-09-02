using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class PassiveUserException : Exception
    {
        public override string Message
        {
            get
            {
                return "Üyeliğiniz henüz aktifleşmemiştir.";
            }
        }
    }
}
