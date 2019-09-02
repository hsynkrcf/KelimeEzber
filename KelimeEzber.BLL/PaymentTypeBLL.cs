using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KelimeEzber.DAL;
using KelimeEzber.Entities;

namespace KelimeEzber.BLL
{
	public class PaymentTypeBLL
	{
		PaymentTypeDAL _paymentType;
		public PaymentTypeBLL()
		{
			_paymentType = new PaymentTypeDAL();
		}

		public bool Add(PaymentType paymentType)
		{
			int affectedRows = _paymentType.Add(paymentType);
			return affectedRows > 0;
		}

		public PaymentType GetPaymentTypeByID(int paymentTypeID)
		{
			return _paymentType.GetTypeByID(paymentTypeID);
		}

		public List<PaymentType> GetAllPaymentTypes()
		{
			return _paymentType.GetAllPaymentTypes();
		}

        public bool Update(PaymentType paymentType)
        {
            int affectedRows = _paymentType.Update(paymentType);
            return affectedRows > 0;
        }

        public bool Delete(int typeID)
        {
            int affectedRows = _paymentType.Delete(typeID);
            return affectedRows > 0;
        }
	}
}
