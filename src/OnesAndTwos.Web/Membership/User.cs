namespace OnesAndTwos.Web.Membership
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(string userName)
        {
            UserName = userName;
        }
    }
}