using ShopApplication.Models;

namespace ShopApplication.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
        public void Add(Category category);
        public Category GetByName(string name);
    }
}
