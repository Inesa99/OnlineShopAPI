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
    public class VendorService : IVendor
    {
        private readonly ShopDbContext _context;

        public VendorService(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<VendorListViewModel>> VendorList()
        {
            List<VendorListViewModel> vendores = _context.Vendors.Select(
                v => new VendorListViewModel
                {
                    VendorId = v.Id,
                    Name = v.Name,
                }
            ).ToList();
            return vendores;
        }
    }
}
