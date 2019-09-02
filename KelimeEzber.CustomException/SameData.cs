using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.CustomException
{
    public class SameData : Exception
    {
        string _data;

        public SameData(string data)
        {
            _data = data;
        }
        public override string Message
        {
            get
            {
                return $"Bu {_data} zaten sistemde mevcut";
            }
        }
    }
}
