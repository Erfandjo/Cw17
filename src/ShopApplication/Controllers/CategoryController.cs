using Microsoft.AspNetCore.Mvc;
using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Services;
using ShopApplication.Models;
using ShopApplication.Service;

namespace ShopApplication.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService CategoryService;
        public CategoryController()
        {
            CategoryService = new CategoryService();
        }
        public IActionResult Index()
        {
            return View(CategoryService.Get());
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(string name)
        {
            Category category = new Category()
            {
                Name = name
            };
             CategoryService.Add(category);
            return RedirectToAction("Index");
        }
    }
}
