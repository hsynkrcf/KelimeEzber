using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class CreditCardNoException : Exception
    {
        string _data;

        public CreditCardNoException(string data)
        {
            _data = data;
        }
        public override string Message
        {
            get
            {
                return $"{_data} numarası hatalı girilmiş";
            }
        }
    }
}
