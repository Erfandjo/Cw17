using Microsoft.AspNetCore.Mvc;
using ShopApplication.Contracts.Services;
using ShopApplication.Service;

namespace ShopApplication.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public IActionResult Index()
        {
            if (Storage.CurrentUser.OnlineUser is not null)
            {
                return View(Storage.CurrentUser.OnlineUser);
            }
            return RedirectToAction("Login", "User");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult SignUpUser(string userName , string password)
        {
            _userService.SignUp(userName, password);

            return RedirectToAction("Index");
        }
        public IActionResult LoginUser(string userName, string password)
        {
            _userService.Login(userName, password);
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            _userService.LogOut();
            return RedirectToAction("Index" , "Home");
        }
    }
}
