using Microsoft.AspNetCore.Mvc;
using SharpShop.Models;
using System.Diagnostics;

namespace SharpShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*
         * The action method "IActionResult" because "IActionResult" is an
         * abstraction for multiple return type.
         * 
         * It ca return a view, it can redirect to some action method, or it can 
         * redirect a page.
         */

        public IActionResult Index()
        {
            // return StatusCode(403);
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