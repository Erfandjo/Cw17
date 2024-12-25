using ShopApplication.Contracts.Repositories;
using ShopApplication.Contracts.Services;
using ShopApplication.DAL.Repositories;
using ShopApplication.Models;

namespace ShopApplication.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public List<Product> Get()
        {
            return _productRepository.GetAll();
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public Product GetForId(int id)
        {
           return _productRepository.GetForId(id);
        }

        public void Update(int id, string name, int price, string description, Category category)
        {
            _productRepository.Update(id , name , price , description , category);
        }
    }
}
