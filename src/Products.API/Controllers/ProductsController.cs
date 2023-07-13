using Microsoft.AspNetCore.Mvc;
using Products.Application.DTOs.Product.Requests;
using Products.Application.Interfaces.Services;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() => Ok(await _productService.GetAllProducts());

        [HttpPost]
        public async Task<IActionResult> InsertCategory(ProductRequest productRequest)
            => Created("/categories", (await _productService.InsertProductAsync(productRequest)).Name);

    }
}
