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
        public List<Product> GetAll()
        {
            return _appDbContext.Products.Include(x => x.category).ToList();
        }
    }
}
