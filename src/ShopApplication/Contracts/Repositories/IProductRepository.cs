using ShopApplication.Models;

namespace ShopApplication.Contracts.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
    }
}
