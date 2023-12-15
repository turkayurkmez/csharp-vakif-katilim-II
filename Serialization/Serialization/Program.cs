// See https://aka.ms/new-console-template for more information
using Serialization;
using System.Text.Json;


var products = new ProductService().GetProducts();
Console.WriteLine(serializeToJson(products));
var result = deserializeFromJson();
result.ForEach(r => Console.WriteLine(r.Name));
Console.WriteLine("Hello, World!");




string serializeToJson(List<Product> products)
{
    string json = JsonSerializer.Serialize<List<Product>>(products);
    File.WriteAllText("products.json", json);
    return json;

}

List<Product> deserializeFromJson()
{
    string json = File.ReadAllText("products.json");
    return (List<Product>)JsonSerializer.Deserialize<List<Product>>(json);

}