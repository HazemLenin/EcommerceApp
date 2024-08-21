using EcommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Interfaces
{
    public interface ICart
    {
        public List<OrderItem> Items { get; set; }
        void AddItem(OrderItem item);
    }
}
