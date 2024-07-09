using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Dependency Injection Pattern
        // DI Service Lifetimes

        // Hiç bir controller repository impl. yapmaz.
        // Hiç bir web api veri erişim katmanı referansı almaz.

        // Controller service implementasyonu yapar.
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return null;
           // return _productRepository.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            _productService.Add(product);
        }
    }
}
