using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Interfaces
{
    public interface IHasDiscount
    {
        public decimal DiscountPercentage { get; set; }
    }
}
