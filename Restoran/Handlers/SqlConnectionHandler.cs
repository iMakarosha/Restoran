using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Handlers
{
    public class SqlConnectionHandler
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(
                    ConfigurationManager.ConnectionStrings["Restoran.Properties.Settings.RestoranConnectionString"].ConnectionString);
        }

        public object GetQueryResult(string str)
        {
            SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection();
            conn.Open();

            SqlCommand MyCommand = new SqlCommand(str, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyCommand);
            object res = MyCommand.ExecuteScalar();

            conn.Close();

            return res;
        }

        public List<object> GetQueryResultList(string str)
        {
            SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection();
            conn.Open();

            SqlCommand MyCommand = new SqlCommand(str, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyCommand);

            SqlDataReader res = MyCommand.ExecuteReader();

            List<object> res1 = new List<object>();

            while (res.Read())
            {
                object[] values = new Object[res.FieldCount];
                int fieldCount = res.GetValues(values);
                res1.Add(values);
            }

            conn.Close();
            return res1;
        }

        public void ExecuteNonQuery(SqlCommand command)
        {
            using (SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection())
            {
                command.Connection = conn;

                conn.Open();

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void ExecuteNonQuery(string queryString)
        {
            using (SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection())
            {
                SqlCommand MyCommand = new SqlCommand(queryString, conn);

                MyCommand.Connection = conn;

                conn.Open();

                MyCommand.ExecuteNonQuery();

                conn.Close();
            }
        }

        public DataSet GetDataSet(string str)
        {
            SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection();
            SqlCommand MyCommand = new SqlCommand(str, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyCommand);

            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds);
            conn.Close();

            return ds;
        }
    }
}
