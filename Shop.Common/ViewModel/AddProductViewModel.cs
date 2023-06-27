using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Common.ViewModel
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int CategoryId { get; set; }
        public int? VendorId { get; set; }
    }
}
