using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    class Helper
    {
        SqlConnection _conn;
        SqlCommand _cmd;

        public Helper()
        {
            _conn = new SqlConnection(Properties.Settings.Default.KEKE);
            _cmd = new SqlCommand();
            _cmd.Connection = _conn;
        }

        public void AddParameters(List<SqlParameter> parameters)
        {
            _cmd.Parameters.Clear();
            _cmd.Parameters.AddRange(parameters.ToArray());
        }

        void ConnOpen()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        public int ExecuteQuery(string query)
        {
            _cmd.CommandText = query;
            ConnOpen();
            int affectedRows = _cmd.ExecuteNonQuery();
            _conn.Close();
            return affectedRows;
        }

        public SqlDataReader ExecuteReader(string query)
        {
            _cmd.CommandText = query;
            ConnOpen();
            SqlDataReader reader = _cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
