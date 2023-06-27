using Microsoft.AspNetCore.Mvc;
using Shop.Application.Interfaces;
using Shop.Common.ViewModel;

namespace OnlineShop.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly ICategory _categoryService;
        public CategoryController(ICategory categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(Name = "GetCategoriesList")]
        public Task<List<CategoryListViewModel>> Get()
        {
            return _categoryService.CategoryList();
        }

        [HttpPost(Name = "AddCategory")]
        public async Task<IActionResult> Add([FromBody] AddCategoryViewModel model)
        {
            //if (!await _categoryService.Add(model)) return error;
            await _categoryService.Add(model);
            return Ok();
        }
    }
}
