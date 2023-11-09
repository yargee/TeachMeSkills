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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddProduct([FromForm] ProductConstructionModel model)
        {
            //тут типа обработка ввода
            _service.AddProduct(new ProductModel(Guid.NewGuid(), model.Name, new ProductInfo(model.Description, model.Quantity,model.Price)));
            return View("Index", _service.GetProducts());
        }

        [HttpPost]
        public IActionResult RemoveProduct([FromForm] ProductDeleteModel model)
        {            
            _service.RemoveProduct(model.Guid);
            return View("Index", _service.GetProducts());
        }

        public IActionResult GetProductsPriceSum([FromForm] ProductsPriceSumKeyModel model )
        {
            return View("Index", _service.CalculatePrice(model.Key));
        }
    }
}