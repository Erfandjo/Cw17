using Microsoft.EntityFrameworkCore;
using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Repositories;
using ShopApplication.Models;

namespace ShopApplication.DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public void Add(Category category)
        {
            if(category is not null)
            {
                _appDbContext.Categories.Add(category);
                _appDbContext.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _appDbContext.Categories.ToList();
        }
        public Category GetByName(string name)
        {
            return _appDbContext.Categories.FirstOrDefault(x => x.Name == name);
        }
        public void Delete(int id)
        {
            var c = _appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            _appDbContext.Categories.Remove(c);
            _appDbContext.SaveChanges();
        }

        public Category GetForId(int id)
        {
            var c = _appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (c is not null)
            {
                return c;
            }
            throw new Exception();
        }

        public void Update(int id, string name)
        {
            var c = _appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            c.Name = name;
            _appDbContext.SaveChanges();
        }
    }
}
