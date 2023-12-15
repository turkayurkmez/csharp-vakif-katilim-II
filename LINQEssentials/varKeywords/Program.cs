// See https://aka.ms/new-console-template for more information
using varKeywords;

Console.WriteLine("Hello, World!");

var anonymType = new { Ad = "Türkay", Yas = 43 };
Console.WriteLine($"{anonymType.Ad} - {anonymType.Yas}");
//LINQ

//Language Integrated Query
var customers = new CustomerService().GetCustomers();
var customersInIstanbul = from customer in customers
                          where customer.City == "İstanbul"
                          select new { customer.Name, customer.Email };

customersInIstanbul.ToList().ForEach(custom => Console.WriteLine($"{custom.Name} {custom.Email}"));

var isCanceled = false;
var name = "Vakıf Katılım";

var value = 8;

var extensionCustomersInIstanbul = customers.Where(c => c.City == "İstanbul")
                                            .Select(c => new { c.Name, c.Email })
                                            .ToList();


