using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string? Logo { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
