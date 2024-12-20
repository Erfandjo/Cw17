using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Repositories;
using ShopApplication.Models;

namespace ShopApplication.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository()
        {
            _appDbContext = new AppDbContext();
        }
        public List<Category> GetAll()
        {
            return _appDbContext.Categories.ToList();
        }
    }
}
