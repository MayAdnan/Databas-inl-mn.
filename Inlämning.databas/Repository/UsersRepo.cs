using Inlämning.databas.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Inlämning.databas.Repository
{
    public class UsersRepo
    {
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
            string sql = "Insert into [User] (Username,PasswordUser) Values (@Username, @PasswordUser)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Username", user.UserName),
                new SqlParameter("@PasswordUser", user.PasswordUser)
            };
               DataContext .ExecuteNonQuery(sql,parameters);
        }

        public User GetUsername(string username)
        {
            string sql = "Select * from [User] Where [Username] = @Username";
            List<SqlParameter> parameters = new List<SqlParameter>

            {
                new SqlParameter("@Username", username)
            };

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new User(
                Convert.ToInt32(row["UsersID"]),
                row["Username"].ToString(),
                row["PasswordUser"].ToString()

                );
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
