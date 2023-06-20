using Microsoft.AspNetCore.Mvc;
using Practical_9.Models;
using System.Diagnostics;

namespace Practical_9.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            
        }
        

        public IActionResult Index()
        {
            string message = "Hello World";
            return View("Index", message);
        }
        public IActionResult Test2()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}