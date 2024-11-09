namespace Inlämning.databas.Entities
{
    public class User
    {
        public int UsersID { get; set; }
        public string UserName { get; set; }
        public string PasswordUser { get; set; }

        public User(int usersID, string userName, string passwordUser)
        {
            UsersID = usersID;
            UserName = userName;
            PasswordUser = passwordUser;
        }
    }
}
