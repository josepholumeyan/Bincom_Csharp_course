using System.Diagnostics;
using BincomProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BincomProject.Controllers
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
            ViewData["Message"] = "Hello World from Joseph";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Experience()
        {
            return View();
        }
        public IActionResult Skills()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaxCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TaxCalculator(decimal income)
        {
            decimal tax = Services.TaxCalculatorService.CalculateTax(income);

            ViewData["Tax"] = tax;
            ViewData["Income"] = income;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
