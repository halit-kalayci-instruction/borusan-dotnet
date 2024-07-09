using Business.Abstract;
using Business.DTO;
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
        // Controller asla dışarıya Entity açmaz, dışardan da entity istemez.
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<ProductForListingDto> GetAll()
        {
           return _productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] ProductForAddDto productForAddDto)
        {
            _productService.Add(productForAddDto);
        }
    }
}
