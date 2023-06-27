using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public string? Url { get; set; }
        public string? PageTitle { get; set; }
       
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? VendorId { get; set; }

        [ForeignKey("VendorId")]
        public virtual Vendor Vendor { get; set; }

        public virtual ICollection<ProductImage> Images { get; set; }

    }
}
