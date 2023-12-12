// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");
Product product = new Product();

product.SetPrice(100);
Console.WriteLine(product.GetPrice());

product.Description = "1 Kilo Mandalina :)";