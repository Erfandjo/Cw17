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
            return _appDbContext.Products.Include(x => x.Category).ToList();
        }

        public void Delete(int id)
        {
            var p = _appDbContext.Products.FirstOrDefault(x => x.Id == id);
            _appDbContext.Products.Remove(p);
            _appDbContext.SaveChanges();
        }

        public Product GetForId(int id)
        {
            var p = _appDbContext.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            if (p is not null)
            {
                return p;
            }
            throw new Exception();
        }

        public void Update(int id, string name, int price, string description, Category category)
        {
            var p = _appDbContext.Products.FirstOrDefault(x => x.Id == id);
            p.Name = name;
            p.Price = price;
            p.Description = description;
            p.CategoryId = category.Id;
            _appDbContext.SaveChanges();
        }
    }
}
