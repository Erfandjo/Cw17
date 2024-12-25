using Microsoft.AspNetCore.Mvc;
using ShopApplication.AppdbContext;
using ShopApplication.Contracts.Services;
using ShopApplication.Models;
using ShopApplication.Service;

namespace ShopApplication.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService categoryService;
        public CategoryController()
        {
            categoryService = new CategoryService();
        }
        public IActionResult Index()
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                return View(categoryService.Get());
            }
            return RedirectToAction("Login", "User");
            
        }

        public IActionResult Add()
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
            
        }
        [HttpPost]
        public IActionResult AddCategory(string name)
        {
           
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                Category category = new Category()
                {
                    Name = name
                };
                categoryService.Add(category);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
        }

        public IActionResult Delete(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                categoryService.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
           
        }

        public IActionResult Update(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var p = categoryService.GetForId(id);
                return View(p);
            }
            return RedirectToAction("Login", "User");
            
        }

        public IActionResult UpdateCategory(int id, string name)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                categoryService.Update(id, name);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
           
        }

        public IActionResult Preview(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var p = categoryService.GetForId(id);
                return View(p);
            }
            return RedirectToAction("Login", "User");
            
        }
    }
}
