using EcommerceApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    public class Payment
    {
        public ICart Cart { get; set; }
        public decimal PriceBeforeDiscount { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
