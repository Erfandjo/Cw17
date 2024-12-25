using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Repositories;
using ShopApplication.Models;

namespace ShopApplication.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository()
        {
            _dbContext = new AppDbContext();
        }

        public User? GetForUserName(string userName)
        {
            return _dbContext.Users.FirstOrDefault(u => u.UserName == userName);
        }

        public bool Login(string username, string password)
        {
           return _dbContext.Users.Any(x => x.UserName == username && x.Password == password);
        }

        public void SignUp(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
