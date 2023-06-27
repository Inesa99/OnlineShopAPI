using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Common.ViewModel;
using Shop.Data.Entities;

namespace OnlineShop.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _productService;
        public ProductController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetProductsList")]
        public List<ProductViewModel> Get()
        {            
            return _productService.ProductList();
        }

        [HttpPost(Name = "AddProduct")]
        public async Task<IActionResult> Add([FromBody]AddProductViewModel model)
        {
            await  _productService.Add(model);
            return Ok();
        }
    }
}
