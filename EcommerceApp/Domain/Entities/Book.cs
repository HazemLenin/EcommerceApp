using EcommerceApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    public class Book : IDiscountedProduct
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int LeftInStock { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string Author { get; set; }
    }
}
