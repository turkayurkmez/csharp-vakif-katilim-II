// See https://aka.ms/new-console-template for more information
using ClassANDObject;

Console.WriteLine("Hello, World!");

Product p1 = new Product();
int x = 5;
p1.Name = "Çamaşır makinesi";
p1.Price = 12000;

Product p2 = p1;

p2.Name = "Kurutma makinesi";
Console.WriteLine(p1.Name);
