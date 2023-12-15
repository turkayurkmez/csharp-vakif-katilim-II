// See https://aka.ms/new-console-template for more information
using LINQPractise;

Console.WriteLine("Hello, World!");
Category phone = new() { Id = 1, Name = "Smart Phone" };
Category wearing = new() { Id = 2, Name = "Wear" };
Category electronic = new() { Id = 3, Name = "Electronic" };

List<Category> categories = new List<Category>() { phone, wearing, electronic };

var products = new List<Product>
{
    new Product{ Id=1, Name="Samsung A51", Price=5000, Description="Android Telefon I", Rating= 4.3, IsStock=true, Category=phone},
    new Product{ Id=2, Name="Iphone 14", Price=35400, Description="IOS Phone", Rating= 4.3, IsStock=false,Category=phone},
    new Product{ Id=3, Name="Xiaomi", Price=6000, Description="Android Telefon II", Rating= 4.3, IsStock=false, Category = phone},
    new Product{ Id=4, Name="Huawei", Price=2000, Description="Android Telefon III", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=5, Name="Rode", Price=1000, Description="Android Telefon IV", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=6, Name="Nokia 3310", Price=750, Description="Android Telefon V", Rating= 4.3, IsStock=true, Category = phone},
    new Product{ Id=7, Name="Shirt", Price=150, Description="Basic Shirt", Rating= 4.3, IsStock=true, Category = wearing},
    new Product{ Id=8, Name="Pant", Price=350, Description="Smart Casual", Rating= 4.3, IsStock=true, Category = wearing},
};

var moreThanAThousand = products.Where(p => p.Price > 1000)
                                .Select(p => new { Ad = p.Name, Fiyat = p.Price })
                                .ToList();

Console.WriteLine("=========== 1000 TL'den fazla olan ürünler =============");
moreThanAThousand.ForEach(product => Console.WriteLine($"{product.Ad}: {product.Fiyat} TL"));

var endsWithI = products.Where(p => p.Name.EndsWith("i"))
                        .ToList();
Console.WriteLine("=========== i harfiyle bitenler ===========");
endsWithI.ForEach(p => Console.WriteLine($"{p.Name}: {p.Price} TL"));

var androidDevices = products.Where(p => p.Description.Contains("Android"))
                             .ToList();
Console.WriteLine("=========== Android'ler ===========");
androidDevices.ForEach(p => Console.WriteLine($"{p.Name} ({p.Description}): {p.Price} TL"));

var pant = products.FirstOrDefault(p => p.Id == 8);
if (pant != null)
{
    Console.WriteLine(pant.Name + "  " + pant.Price);
}
else
{
    Console.WriteLine("9 nolu ürün bulunamadı");
}

//var android = products.SingleOrDefault(p => p.Description.Contains("Android"));
//Console.WriteLine(android.Name);

var orderedProductsAsc = products.OrderBy(p => p.Price);
var orderedProductsDesc = products.OrderByDescending(p => p.Price);


/*
 * Aggregates:
 */
var totalPrice = products.Sum(p => p.Price);
var avgPrice = products.Average(p => p.Price);
var maxPrice = products.Max(p => p.Price);
var count = products.Count(p => !p.IsStock);
Console.WriteLine(" ============================ Aggregates ==================");

Console.WriteLine($"toplam: {totalPrice}, ortalama: {avgPrice}, en pahalı: {maxPrice}, stokta olmayanların sayısı:{count}");

Console.WriteLine(" ============================ Join ==================");


var join = categories.Join(inner: products,
                           outerKeySelector: category => category,
                           product => product.Category,
                           resultSelector: (category, product) => new { CategoryName = category.Name, UrunAdi = product.Name })
                           ;
foreach (var anonymous in join)
{
    Console.WriteLine(anonymous.CategoryName + "-" + anonymous.UrunAdi);
}

var alternative = products.Select(p => new { Product = p.Name, Category = p.Category.Name }).ToList();
alternative.ForEach(a => Console.WriteLine($"{a.Product} - {a.Category}"));

Console.WriteLine(" ============================ Group By ==================");

var group = products.GroupBy(keySelector: product => product.Category.Name,
                             elementSelector: product => new { product.Name, product.Price },
                             resultSelector: (cname, products) => new
                             {
                                 CategoryName = cname,
                                 Count = products.Count(),
                                 Min = products.Min(x => x.Price),
                                 Max = products.Max(x => x.Price),
                                 Avg = products.Average(x => x.Price)
                             });

foreach (var item in group)
{
    Console.WriteLine($"Kategori Adı: {item.CategoryName}\nToplam ürün sayısı:{item.Count}\nEn pahalı:{item.Max}\nEn ucuz:{item.Min}\nortalama:{item.Avg}");
}


