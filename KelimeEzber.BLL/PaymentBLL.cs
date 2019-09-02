using KelimeEzber.DAL;
using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.BLL
{
    public class PaymentBLL
    {
        PaymentDAL _paymentDAL;
        public PaymentBLL()
        {
            _paymentDAL = new PaymentDAL();
        }

        public bool Add(Payment payment)
        {
            int affectedRows = _paymentDAL.Add(payment);
            return affectedRows > 0;
        }

        public Payment GetPaymentByID(int paymentID)
        {
            return _paymentDAL.GetPaymentByID(paymentID);
        }

        public decimal GetAllPaymentsByDates(string startDate, string endDate)
        {
            return _paymentDAL.GetSumOfPaymentsByDate(startDate, endDate);
        }

        public bool Update(Payment payment)
        {
            int affectedRows = _paymentDAL.Update(payment);
            return affectedRows > 0;
        }

        public bool Delete(int paymentID)
        {
            int affectedRows = _paymentDAL.Delete(paymentID);
            return affectedRows > 0;
        }
    }
}
