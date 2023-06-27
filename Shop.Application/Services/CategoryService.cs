using Shop.Application.Interfaces;
using Shop.Common.ViewModel;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class CategoryService : ICategory
    {
        private readonly ShopDbContext _context;

        public CategoryService(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryListViewModel>> CategoryList()
        {
            List<CategoryListViewModel> categories = _context.Categorys.Select(
                v => new CategoryListViewModel
                {
                    CategoryId = v.CategoryId,
                    Name = v.Name,
                }
            ).ToList();
            return categories;
        }
    }
}
