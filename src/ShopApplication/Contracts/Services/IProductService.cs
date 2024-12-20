using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface IProductService
    {
        public List<Product> Get();
        public void Add(Product product);
    }
}
