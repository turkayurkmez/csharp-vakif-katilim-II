// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");
string value = "vakıf katılım kuruluşu ";
int x = 8;
Console.WriteLine(x.GetSpesificPower(3));
Console.WriteLine(value.ToTitle());

DateTime nextYear = new DateTime(2024, 1, 1);
var holidays = new DateTime[] {
    new DateTime(2024, 1, 1),
    new DateTime(2024, 4, 23),
    new DateTime(2024, 5, 19)
};

Console.WriteLine(nextYear.TotalWorkDays(holidays));

Console.WriteLine(new Random().NextString(5));