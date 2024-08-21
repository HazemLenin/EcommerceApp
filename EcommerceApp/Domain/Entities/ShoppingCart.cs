using EcommerceApp.Domain.Entities;
using EcommerceApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class ShoppingCart : ICart
    {
        public List<OrderItem> Items { get; set; } = [];

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
