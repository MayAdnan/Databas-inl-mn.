using System.Data;
using System.Data.SqlClient;

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

                if (parmeters != null)
                {
                    cmd.Parameters.AddRange(parmeters.ToArray());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable result = new DataTable();
                adapter.Fill(result);

                return result;
            }
        }

        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}
