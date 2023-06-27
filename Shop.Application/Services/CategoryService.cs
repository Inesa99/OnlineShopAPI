using Shop.Application.Interfaces;
using Shop.Common.ViewModel;
using Shop.Data;
using Shop.Data.Entities;
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

        public async Task<bool> Add(AddCategoryViewModel category)
        {
            if (_context.Categorys.Select(i => i.Name).Contains(category.Name) || category == null) return false;
            Category newCategory = new Category
            {
                Name = category.Name,
                Url = category.Name,
            };
            await _context.Categorys.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return true;
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
