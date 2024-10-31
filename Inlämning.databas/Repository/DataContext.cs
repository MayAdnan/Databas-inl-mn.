using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Repository
{
    public static class DataContext
    {
        private static string _connString= "Data Source=localhost;Initial Catalog=AnnonsDatabas;Integrated Security=SSPI;TrustServerCertificate=True;";

        public static DataTable ExecuteQueryReturnTable(string sql, List<SqlParameter> parmeters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter parameter in parmeters)
                {
                    cmd.Parameters.Add(parameter);
                }

                DataTable result = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(result);

                return result;
            }
        }

    }
}
