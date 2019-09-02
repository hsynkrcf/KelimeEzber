using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class PaymentTypeDAL
    {
        Helper helper;

        public PaymentTypeDAL()
        {
            helper = new Helper();
        }

        public int Add(PaymentType type)
        {
            string query = "INSERT INTO PaymentType(TypeDesc) VALUES(@typeDesc)";
			List<SqlParameter> parameters = GetParameters(type);
			helper.AddParameters(parameters);
			return helper.ExecuteQuery(query);
		}

		private List<SqlParameter> GetParameters(PaymentType type)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@typeDesc", type.TypeDescription));
			return parameters;
		}

		public PaymentType GetTypeByID(int typeID)
		{
			string query = "SELECT * FROM PaymentType WHERE TypeID = @typeID";
			helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@typeID", typeID) });
			SqlDataReader reader = helper.ExecuteReader(query);
			reader.Read();
			PaymentType type = GetPaymentType(reader);
			reader.Close();
			return type;
		}

		private PaymentType GetPaymentType(SqlDataReader reader)
		{
			PaymentType type = new PaymentType();
			type.TypeID = reader.GetInt32(0);
			type.TypeDescription = reader.GetString(1);
			return type;
		}

		public List<PaymentType> GetAllPaymentTypes()
		{
			List<PaymentType> paymentTypes = new List<PaymentType>();
			string query = "SELECT * FROM PaymentType";
			SqlDataReader reader = helper.ExecuteReader(query);
			while (reader.Read())
			{
				paymentTypes.Add(GetPaymentType(reader));
			}
			reader.Close();
			return paymentTypes;
		}
		public int Update(PaymentType paymentType)
		{
			string query = "UPDATE PaymentType SET TypeDesc = @typeDesc WHERE TypeID = @typeID";
			List<SqlParameter> parameters = GetParameters(paymentType);
			helper.AddParameters(parameters);
			return helper.ExecuteQuery(query);
		}

		public int Delete(int typeID)
		{
			string query = "DELETE FROM PaymentType WHERE TypeID = @typeID";
			helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@typeID", typeID) });
			return helper.ExecuteQuery(query);
		}
	}
}
