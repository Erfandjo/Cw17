using Microsoft.EntityFrameworkCore;
using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Repositories;
using ShopApplication.Models;

namespace ShopApplication.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public void Add(Product product)
        {
            if (product is not null)
            {
                _appDbContext.Products.Add(product);
                _appDbContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return _appDbContext.Products.Include(x => x.category).ToList();
        }
    }
}
