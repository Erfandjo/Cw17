using ShopApplication.Models;

namespace ShopApplication.Contracts.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public void Add(Product product);
        public void Delete(int id);
        public Product GetForId(int id);
        public void Update(int id, string name, int price, string description, Category category);
    }
}
