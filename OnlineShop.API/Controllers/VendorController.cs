using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Common.ViewModel;

namespace OnlineShop.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VendorController : Controller
    {
        private readonly IVendor _vendorService;
        public VendorController(IVendor vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpGet(Name = "GetVendorsList")]
        public Task<List<VendorListViewModel>> Get()
        {
            return _vendorService.VendorList();
        }

        [HttpPost(Name = "AddVendor")]
        public async Task<IActionResult> Add([FromBody] AddVendorViewModel model)
        {
            //if (!await _vendorService.Add(model)) return error;
            await _vendorService.Add(model);
            return Ok();
        }
    }
}
