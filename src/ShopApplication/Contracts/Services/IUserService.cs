using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface IUserService
    {
        public void Login(string userName, string password);

        public void SignUp(string userName, string password);
        public void LogOut();
    }
}
