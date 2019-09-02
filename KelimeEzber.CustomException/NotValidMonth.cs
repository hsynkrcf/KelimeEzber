using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class NotValidMonth : Exception
    {
        string _data;

        public NotValidMonth(string data)
        {
            _data = data;
        }
        public override string Message
        {
            get
            {
                return $"{_data} değeri geçersiz!";
            }
        }
    }
}
