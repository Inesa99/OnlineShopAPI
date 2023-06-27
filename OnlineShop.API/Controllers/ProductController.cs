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
        private readonly IVendor _vendorService;
        private readonly ICategory _categoryService;
        public ProductController(IProduct productService, IVendor vendorService, ICategory categoryService)
        {
            _productService = productService;
            _vendorService = vendorService;
            _categoryService = categoryService;
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
