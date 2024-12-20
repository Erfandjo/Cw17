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
    }
}
