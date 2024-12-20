using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface ICategoryService
    {
        public List<Category> Get();
        public void Add(Category category);
        public Category GetByName(string name);
    }
}
