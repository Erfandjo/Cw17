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

        public void Add(Category category)
        {
            if(category is not null)
            {
                _appDbContext.Categories.Add(category);
                _appDbContext.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _appDbContext.Categories.ToList();
        }
        public Category GetByName(string name)
        {
            return _appDbContext.Categories.FirstOrDefault(x => x.Name == name);
        }
    }
}
