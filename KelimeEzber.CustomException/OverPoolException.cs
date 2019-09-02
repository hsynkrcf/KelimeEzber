using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class OverPoolException : Exception
    {
        public override string Message
        {
            get
            {
                return "Kısıtlı üyeler sadece bir havuz oluşturabilirler.";
            }
        }
    }
}
