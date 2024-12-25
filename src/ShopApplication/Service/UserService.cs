using ShopApplication.Contracts.Repositories;
using ShopApplication.Contracts.Services;
using ShopApplication.DAL.Repositories;
using ShopApplication.Models;

namespace ShopApplication.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public void Login(string userName, string password)
        {
            if (_userRepository.Login(userName, password))
            {
                var user = _userRepository.GetForUserName(userName);
                Storage.CurrentUser.OnlineUser = user;
            }
        }

        public void SignUp(string userName, string password)
        {
            if (userName is not null && password is not null)
            {
                User u = new User()
                {
                    UserName = userName,
                    Password = password
                };
                _userRepository.SignUp(u);
            }
        }

        public void LogOut()
        {
            Storage.CurrentUser.OnlineUser = null;
        }
    }
}
