using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Interfaces
{
    public interface IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int LeftInStock { get; set; }

    }
}
