using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KelimeEzber.Entities;

namespace KelimeEzber.DAL
{
	public class PaymentDAL
	{
		Helper helper;
		public PaymentDAL()
		{
			helper = new Helper();
		}
		public int Add(Payment payment)
		{
			string query = "INSERT INTO Payment (TypeID, UserID, PaymentDate, Price) VALUES (@typeID,@userID, @paymentDate, @price)";
			List<SqlParameter> parameters = GetParameters(payment, false);
			helper.AddParameters(parameters);

			return helper.ExecuteQuery(query);
		}

		private List<SqlParameter> GetParameters(Payment payment, bool isUpdate)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			if (isUpdate)
			{
				parameters.Add(new SqlParameter("@paymentID", payment.PaymentID));
			}
			parameters.Add(new SqlParameter("@typeID", payment.TypeID));
			parameters.Add(new SqlParameter("@userID", payment.UserID));
			parameters.Add(new SqlParameter("@paymentDate", payment.PaymentDate));
			parameters.Add(new SqlParameter("@price", payment.Price));
			return parameters;
		}

		public Payment GetPaymentByID(int paymentID)
		{
			string query = "SELECT * FROM Payment WHERE PaymentID = @paymentID";
			helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@paymentID", paymentID) });
			SqlDataReader reader = helper.ExecuteReader(query);
			reader.Read();
			Payment payment = GetPayment(reader);
			reader.Close();
			return payment;
		}

		private static Payment GetPayment(SqlDataReader reader)
		{
			Payment payment = new Payment();
			payment.PaymentID = reader.GetInt32(0);
			payment.TypeID = reader.GetInt32(1);
			payment.UserID = reader.GetInt32(2);
			payment.PaymentDate = reader.GetDateTime(3);
			payment.Price = reader.GetDecimal(4);
			return payment;
		}

		public decimal GetSumOfPaymentsByDate(string startDate, string endDate)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string query = "SELECT ISNULL(SUM(Price),0) FROM Payment WHERE(CONVERT(VARCHAR(10), PaymentDate, 121) BETWEEN @endDate AND @startDate)";
			parameters.Add(new SqlParameter("@startDate", startDate));
			parameters.Add(new SqlParameter("@endDate", endDate));
			helper.AddParameters(parameters);

			decimal sumOfPayment = 0;
			SqlDataReader reader = helper.ExecuteReader(query);
			reader.Read();
            sumOfPayment = reader.GetDecimal(0); 
			reader.Close();
			return sumOfPayment;
		}

		public int Update(Payment payment)
		{
			string query = "UPDATE Payment SET TypeID = @typeID, UserID = @userID, PaymenDate = @paymentDate, Price = @price WHERE PaymentID = @paymentID";
			List<SqlParameter> parameters = GetParameters(payment,true);
			helper.AddParameters(parameters);

			return helper.ExecuteQuery(query);
		}
		public int Delete(int paymentID)
		{
			string query = "DELETE FROM Payment WHERE PaymentID = @paymentID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@paymentID", paymentID) });
            return helper.ExecuteQuery(query);
		}
	}
}
