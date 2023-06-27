using Shop.Application.Interfaces;
using Shop.Common.ViewModel;
using Shop.Data;
using Shop.Data.Entities;

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
                    VendorId = v.VendorId,
                    Name = v.Name,
                }
            ).ToList();
            return vendores;
        }
        public async Task<bool> Add(AddVendorViewModel vendor)
        {
            if (_context.Vendors.Select(v => v.Name).Contains(vendor.Name) || vendor == null) return false;
            Vendor newVendor = new Vendor
            {
                Name = vendor.Name,
                Created = DateTime.Now,
            };
            await _context.Vendors.AddAsync(newVendor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
