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
    }
}
