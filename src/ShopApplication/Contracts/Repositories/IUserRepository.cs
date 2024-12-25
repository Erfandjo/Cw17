using ShopApplication.Models;

namespace ShopApplication.Contracts.Repositories
{
    public interface IUserRepository
    {
        public bool Login(string username, string password);
        public void SignUp(User user);
        public User GetForUserName(string userName);
    }
}
