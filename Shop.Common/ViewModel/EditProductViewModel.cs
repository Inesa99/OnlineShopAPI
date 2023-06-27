using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Common.ViewModel
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int DaysCount { get; set; }
        public List<int> Categorys { get; set; }
    }
}
