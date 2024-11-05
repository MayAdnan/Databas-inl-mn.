using Inlämning.databas.Entities;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Repository
{
    public class UsersRepo
    {
        private static string _connString = "Data Source=localhost;Initial Catalog=AnnonsDatabas;Integrated Security=SSPI;TrustServerCertificate=True;";
        public User Login(string username, string PasswordUser)
        {
            User user = GetUsername(username);
            if (user != null && user.PasswordUser == PasswordUser)
            {

                return user;
            }
            return null;

        }

        public void Save(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string sql = "Insert into User (Username,PasswordUser) Values (@Username, @PasswordUser)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", user.UserName);
                cmd.Parameters.AddWithValue("@PasswordUser", user.PasswordUser);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public User GetUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string sql = "Select * from User Where Username = @Username";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Username", username);
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User(
                          reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        );
                    }
                }
            }
            return null;
        }
        public bool CreateUser(User user)
        {
           if (GetUsername (user.UserName) != null) 
            {
                return false;
            }
           Save(user);
            return true;
        }
    }
}
