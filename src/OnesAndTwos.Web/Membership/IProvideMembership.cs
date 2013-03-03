namespace OnesAndTwos.Web.Membership
{
    public class RavenMembershipProvider : IProvideMembership
    {
        private readonly IUserStore _userStore;
        private readonly IApplicationEnvironment _applicationEnvironment;

        public RavenMembershipProvider(IUserStore userStore, IApplicationEnvironment applicationEnvironment)
        {
            _userStore = userStore;
            _applicationEnvironment = applicationEnvironment;
        }

        public bool Login(string userName, string password, bool rememberMe)
        {
            
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public void CreateAccount(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool HasLocalAccount(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool ChangePassword(string name, string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public void SetLocalPassword(string name, string newPassword)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IUserStore
    {
    }

    public interface IApplicationEnvironment
    {
    }

    public interface IProvideMembership
    {
        bool Login(string userName, string password, bool rememberMe);
        void Logout();
        void CreateAccount(User user);
        bool HasLocalAccount(string name);
        bool ChangePassword(string name, string oldPassword, string newPassword);
        void SetLocalPassword(string name, string newPassword);
    }
}