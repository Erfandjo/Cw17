using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopApplication.Contracts.Services;
using ShopApplication.Models;
using ShopApplication.Service;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ShopApplication.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;
        ICategoryService categoryService;
        public ProductController()
        {
            productService = new ProductService();
            categoryService = new CategoryService();
        }

        public IActionResult Index()
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                return View(productService.Get());
            }
            return RedirectToAction("Login", "User");
        }
        public IActionResult Add()
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                return View(categoryService.Get());
            }
            return RedirectToAction("Login", "User");
            
        }
        public IActionResult AddProduct(string name , int price , string description , string categoryName)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var category = categoryService.GetByName(categoryName);
                Product product = new Product()
                {
                    CategoryId = category.Id,
                    Name = name,
                    Price = price,
                    Description = description
                };

                productService.Add(product);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
           
        }

        public IActionResult Delete(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                productService.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
           
        }

        public IActionResult Update(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var p = productService.GetForId(id);
                ProductUpdateViewModel model = new ProductUpdateViewModel()
                {
                    Id = id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Category = p.Category,
                    Categories = categoryService.Get()

                };
                return View(model);
            }
            return RedirectToAction("Login", "User");
          
        }
        public IActionResult UpdateProduct(int id , string name, int price, string description, string categoryName)
        {
            
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var category = categoryService.GetByName(categoryName);
                productService.Update(id, name, price, description, category);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login", "User");
        }

        public IActionResult Preview(int id)
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                var p = productService.GetForId(id);
                return View(p);
            }
            return RedirectToAction("Login", "User");
          
        }

    }
}
