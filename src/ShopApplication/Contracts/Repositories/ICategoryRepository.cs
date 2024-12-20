using ShopApplication.Models;

namespace ShopApplication.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
    }
}
