using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hw1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult MyHobbies()
        {
            return View();
        }
        public IActionResult Favourites()
        {
            return View();
        }
        public IActionResult MyPlans()
        {
            return View();
        }
    }
}
