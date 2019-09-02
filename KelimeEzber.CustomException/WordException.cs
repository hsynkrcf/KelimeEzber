using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class WordException : Exception
    {
        public override string Message
        {
            get
            {
                return "Aynı kelime bir daha eklenemez";
            }
        }
    }
}
