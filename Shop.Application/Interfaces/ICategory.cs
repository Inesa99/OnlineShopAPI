using Shop.Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Interfaces
{
    public interface ICategory
    {
        public Task<List<CategoryListViewModel>> CategoryList();
    }
}
