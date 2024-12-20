using Microsoft.AspNetCore.Mvc;
using ShopApplication.Contracts.Services;
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
    }
}
