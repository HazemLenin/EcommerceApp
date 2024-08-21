using EcommerceApp.Domain.Entities;
using EcommerceApp.Domain.Interfaces;
using EcommerceApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Infrastructure.Services
{
    public class PaymentService(ICart cart) : IPaymentService
    {
        public ICart Cart { get; set; } = cart;
        public decimal CalculateTotal() => Cart.Items.Sum(item => item.FinalPrice);
        public decimal CalculateTotalWithoutDiscount() => Cart.Items.Sum(item => item.PriceWithoutDiscount);

        public Payment Checkout()
        {
            // Reducing stock
            foreach (var item in Cart.Items)
            {
                item.Product.LeftInStock -= item.Quantity;
            }

            // Process Payment
            Payment payment = new()
            {
                Cart = Cart,
                PriceBeforeDiscount = CalculateTotalWithoutDiscount(),
                FinalPrice = CalculateTotal()
            };

            return payment;
        }
    }
}
