using EcommerceApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    public class OrderItem
    {
        public IDiscountedProduct Product { get; set; }
        public int Quantity { get; set; }
        public decimal PriceWithoutDiscount { get => Product.Price * Quantity; }
        public decimal FinalPrice { get => (Product.Price - (Product.Price * Product.DiscountPercentage)) * Quantity; }
    }
}
