using ShopApplication.Models;

namespace ShopApplication.Contracts.Services
{
    public interface IProductService
    {
        public List<Product> Get();
        public void Add(Product product);
        public void Delete(int Id);
        public Product GetForId(int id);
        public void Update(int id, string name, int price, string description, Category category);
    }
}
