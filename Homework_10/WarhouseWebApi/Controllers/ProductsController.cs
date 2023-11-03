using Microsoft.AspNetCore.Mvc;
using WarhouseWebApi.Services;
using WarhouseWebApi.Models;

namespace WarhouseWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _service.AddProduct(product);
            return Ok();
        }

        [HttpPost]
        public ProductModel[] GetProducts()
        {
            return _service.GetProducts();
        }
    }
}
