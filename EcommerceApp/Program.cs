// Initializing products
using EcommerceApp;
using EcommerceApp.Domain.Entities;
using EcommerceApp.Domain.Interfaces;
using EcommerceApp.Infrastructure.Services;


Console.WriteLine("Initializing Products...");

Book harryPotterBook = new()
{
    Name = "Harry Potter",
    DiscountPercentage = .5m,
    LeftInStock = 10,
    Price = 100,
    Author = "J.K. Rowling"
};

Book hamletBook = new()
{
    Name = "Hamlet",
    DiscountPercentage = 0,
    LeftInStock = 5,
    Price = 150,
    Author = "William Shakespear"
};

Apparel apparel = new()
{
    Name = "Normal Apparel",
    DiscountPercentage = .7m,
    LeftInStock = 20,
    Price = 90,
    Size = 45
};

Console.WriteLine("Products Initialized!");

PrintProducts();

PrintDivider();

List<OrderItem> orderItems = [];
orderItems.Add(new()
{
    Product = harryPotterBook,
    Quantity = 1
});

orderItems.Add(new()
{
    Product = harryPotterBook,
    Quantity = 1
});

orderItems.Add(new()
{
    Product = hamletBook,
    Quantity = 2
});

orderItems.Add(new()
{
    Product = apparel,
    Quantity = 10
});

ICart cart = new ShoppingCart()
{
    Items = orderItems
};

Console.WriteLine("Ordered Items:");
foreach(var item in orderItems)
{
    Console.WriteLine(item.Product.Name);
    Console.WriteLine($"\tProduct Price: {item.Product.Price}");
    Console.WriteLine($"\tQuantity: {item.Quantity}");
    Console.WriteLine($"\tTotal Price With No Discount: {item.PriceWithoutDiscount}");
    Console.WriteLine($"\tTotal Price: {item.FinalPrice}");
    Console.WriteLine();
}

PrintDivider();

Console.WriteLine("Proccess Payment...");

PaymentService paymentService = new(cart);

var payment = paymentService.Checkout();

Console.WriteLine($"Total Price With No Discount: {payment.PriceBeforeDiscount}");
Console.WriteLine($"Total Price: {payment.FinalPrice}");

PrintDivider();

PrintProducts();







void PrintProducts()
{

    Console.WriteLine($"{harryPotterBook.Name}");
    Console.WriteLine($"\tAuthor: {harryPotterBook.Author}");
    Console.WriteLine($"\tPrice: {harryPotterBook.Price}");
    Console.WriteLine($"\tDiscount: {harryPotterBook.DiscountPercentage}");
    Console.WriteLine($"\tStock: {harryPotterBook.LeftInStock}");

    Console.WriteLine();

    Console.WriteLine($"{hamletBook.Name}");
    Console.WriteLine($"\tAuthor: {hamletBook.Author}");
    Console.WriteLine($"\tPrice: {hamletBook.Price}");
    Console.WriteLine($"\tDiscount: {hamletBook.DiscountPercentage}");
    Console.WriteLine($"\tStock: {hamletBook.LeftInStock}");

    Console.WriteLine();
    
    Console.WriteLine($"{apparel.Name}");
    Console.WriteLine($"\tSize: {apparel.Size}");
    Console.WriteLine($"\tPrice: {apparel.Price}");
    Console.WriteLine($"\tDiscount: {apparel.DiscountPercentage}");
    Console.WriteLine($"\tStock: {apparel.LeftInStock}");

}

void PrintDivider()
{
    Console.WriteLine();
    Console.WriteLine("=====================================================");
    Console.WriteLine();
}