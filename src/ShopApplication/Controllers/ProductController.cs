using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopApplication.Contracts.Services;
using ShopApplication.Models;
using ShopApplication.Service;

namespace ShopApplication.Controllers
{
    public class ProductController : Controller
    {
        IProductService ProductService;
        ICategoryService CategoryService;
        public ProductController()
        {
            ProductService = new ProductService();
            CategoryService = new CategoryService();
        }
        public IActionResult Index()
        {
            return View(ProductService.Get());
        }
        public IActionResult Add()
        {
            return View(CategoryService.Get());
        }
        public IActionResult AddProduct(string name , int price , string description , string categoryName)
        {
            var category = CategoryService.GetByName(categoryName);
            Product product = new Product()
            {
                CategoryId = category.Id,
                Name = name,
                Price = price,
                Description = description
            };

            ProductService.Add(product);

            return RedirectToAction("Index");
        }
    }
}
