using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface ICategoryService
    {
        public List<Category> Get();
        public void Add(Category category);
        public Category GetByName(string name);
        public void Delete(int id);
        public Category GetForId(int id);
        public void Update(int id, string name);
    }
}
