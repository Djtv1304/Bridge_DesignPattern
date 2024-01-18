using Bridge_DesignPattern.Models;
using Bridge_DesignPattern.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bridge_DesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            // Start the Churro Factory
            ViewBag.smallChurroFactory =  Util.smallChurroFactory;
            ViewBag.mediumChurroFactory = Util.mediumChurroFactory;
            ViewBag.largeChurroFactory = Util.largeChurroFactory;

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
