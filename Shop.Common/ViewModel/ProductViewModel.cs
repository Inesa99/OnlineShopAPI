using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Common.ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string? ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public string? Url { get; set; }
        public string? PageTitle { get; set; }
        public int CategoryId { get; set; }
        public int? VendorId { get; set; }
    }
}
