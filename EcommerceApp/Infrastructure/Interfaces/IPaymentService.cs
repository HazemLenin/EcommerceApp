using EcommerceApp.Domain.Entities;
using EcommerceApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Infrastructure.Interfaces
{
    public interface IPaymentService
    {
        public ICart Cart { get; set; }
        decimal CalculateTotal();
        public Payment Checkout();
    }
}
