using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface ICategoryService
    {
        public List<Category> Get();
    }
}
