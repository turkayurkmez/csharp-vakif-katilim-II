// See https://aka.ms/new-console-template for more information
using varKeywords;

Console.WriteLine("Hello, World!");

var anonymType = new { Ad = "Türkay", Yas = 43 };
Console.WriteLine($"{anonymType.Ad} - {anonymType.Yas}");
//LINQ
//Language Integrated Query
var customersInIstanbul = from customer in new CustomerService().GetCustomers()
                          where customer.City == "İstanbul"
                          select customer;

customersInIstanbul.ToList().ForEach(custom => Console.WriteLine($"{custom.Name} {custom.City}"));