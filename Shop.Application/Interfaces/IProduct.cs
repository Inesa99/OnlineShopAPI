using Shop.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Shop.Application.Interfaces
{
    public interface IProduct
    {
        public Task<bool> Add(AddProductViewModel product);
        public Task<bool> Edit(EditProductViewModel product);
        public Task<bool> Delete(EditProductViewModel product);
        public List<ProductViewModel> ProductList();
    }
}
