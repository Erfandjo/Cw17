using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Repositories;
using ShopApplication.Contracts.Services;
using ShopApplication.DAL.Repositories;
using ShopApplication.Models;

namespace ShopApplication.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public List<Category> Get()
        {
            return _categoryRepository.GetAll();
        }
        public Category GetByName(string name)
        {
            return _categoryRepository.GetByName(name);
        }
        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category GetForId(int id)
        {
            return _categoryRepository.GetForId(id);
        }

        public void Update(int id, string name)
        {
            _categoryRepository.Update(id, name);
        }
    }
}
