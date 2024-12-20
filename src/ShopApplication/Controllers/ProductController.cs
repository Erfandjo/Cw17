using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopApplication.Contracts.Services;
using ShopApplication.Service;

namespace ShopApplication.Controllers
{
    public class ProductController : Controller
    {
        IProductService ProductService;
        public ProductController()
        {
            ProductService = new ProductService();
        }
        public IActionResult Index()
        {
            return View(ProductService.Get());
        }
    }
}
