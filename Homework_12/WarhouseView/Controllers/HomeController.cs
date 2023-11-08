using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarhouseView.Models;
using WarhouseView.Services;

namespace WarhouseView.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _service;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View("Index", _service.GetProducts());
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

        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _service.AddProduct(product);
            return Ok();
        }

        public ProductsPriceSumModel GetProductsPriceSum(string key)
        {
            return _service.CalculatePrice(key);
        }
    }
}