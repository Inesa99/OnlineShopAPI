using Shop.Common.ViewModel;
using Shop.Application.Interfaces;
using Shop.Data;
using Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace Shop.Application.Services
{
    public class ProductService : IProduct
    {
        private readonly ShopDbContext _context;

        public ProductService(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(AddProductViewModel product)
        {
           
            if (product == null) return false;
            double newPrice = product.Price;
            if(product.Discount > 0)
            {
                newPrice = (double)(product.Price - (product.Price * product.Discount / 100));
            }
            Product newProduct = new Product
            {
                Name = product.Name,
                Price = newPrice,
                Discount = product.Discount,
                ShortDescription = product.ShortDescription,
                FullDescription = product.FullDescription,
                CategoryId = product.CategoryId,
                VendorId =product.VendorId
            };
           await _context.Products.AddAsync(newProduct);
           await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edit(EditProductViewModel product)
        {
            var entity = await  _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == product.ProductId);
            _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(EditProductViewModel product)
        {
            var entity = await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == product.ProductId);
            if(entity == null)
            {
                return false;
            }
            _context.Products.Remove(entity);
            _context.SaveChangesAsync();
            return true;
        }

        public List<ProductViewModel> ProductList()
        {
            List<ProductViewModel> products = _context.Products
                .Select(item => new ProductViewModel
                {
                    ProductId = item.ProductId,
                    Name = item.Name,
                    Price = item.Price,
                    Discount = item.Discount,
                    ShortDescription = item.ShortDescription,
                    FullDescription = item.FullDescription,
                    Url = item.Url,
                    PageTitle = item.PageTitle,
                    CategoryId = item.CategoryId,
                    VendorId = item.VendorId,
                }).ToList();
            
            return products;
        }
    }
}
