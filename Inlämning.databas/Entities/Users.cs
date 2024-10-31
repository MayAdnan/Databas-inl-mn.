using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning.databas.Entities
{
    public class Users
    {
        public int UsersID { get; set; }
        public string UserName { get; set; }
        public string PasswordUser { get; set; }

        public Users(int usersID, string userName, string passwordUser)
        {
            UsersID = usersID;
            UserName = userName;
            PasswordUser = passwordUser;
        }
    }
}
