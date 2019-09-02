using KelimeEzber.CustomException;
using KelimeEzber.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.WinForm.Classes
{
    public class PaymentHelper
    {
        public void CheckCreditCardNo(string creditCardNo)
        {
            if (creditCardNo.Length == 16)
            {
                try
                {
                    IsDigit(creditCardNo, "Kredi kartı");
                }
                catch
                {
                }
            }
            else
            {
                throw new Exception("Kredi kartı numarasını eksik ya da hatalı girdiniz");
            }
        }

        public void CheckSecurityNo(string securityNo)
        {
            if (securityNo.Length == 3)
            {
                try
                {
                    IsDigit(securityNo, "Güvenlik numarası");
                }
                catch
                {

                }
            }
            else
            {
                throw new Exception("Güvenlik numarası 3 karakterden az olamaz");
            }
        }

        public void CheckMonth(string month)
        {
            if (month.Length == 2)
            {
                try
                {
                    IsDigit(month, "Ay");
                    IsValid(month, true);
                }
                catch
                {
                }
            }
            else
            {
                throw new Exception("Geçersiz bir değer girdiniz");
            }
        }

        public void CheckYear(string year)
        {
            if (year.Length == 2)
            {
                try
                {
                    IsDigit(year, "Yıl");
                    IsValid(year, false);
                }
                catch
                {
                }
            }
            else
            {
                throw new Exception("Geçersiz bir değer girdiniz");
            }
        }

        void IsDigit(string creditCardNo, string type)
        {
            foreach (char item in creditCardNo)
            {
                if (!char.IsDigit(item))
                {
                    throw new CreditCardNoException(type);
                }
            }
        }

        void IsValid(string month, bool isMonth)
        {
            int value = 0;
            bool valid = int.TryParse(month, out value);
            if (!valid)
            {
                throw new NotValidMonth(isMonth ? "Ay" : "Yıl");
            }
            if (isMonth)
            {
                if (value < 1 && value > 12)
                {
                    throw new NotValidMonth("Ay");
                }
            }
            else
            {
                if (value < 19)
                {
                    throw new NotValidMonth("Yıl");
                }
            }
        }

        
    }
}
