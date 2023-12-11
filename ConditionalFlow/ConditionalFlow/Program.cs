// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime today = DateTime.Today;
if (today.Month == 7 && today.Day == 1)
{
    Console.WriteLine("Türkay'ın doğum günü");
}

if (today.Month == 12 || today.Month == 2)
{
    Console.WriteLine("Kış");
}
else if (today.Month == 7 || today.Month == 8)
{
    Console.WriteLine("YAZ");
}

int number = 8;
//ternary operatör:
string message = number % 2 == 0 ? "Çift" : "Tek";
//if (number % 2 == 0)
//{
//    message = "Çift";
//}
//else
//{
//    message = "Tektir";
//}


Console.WriteLine("Trafik Lambası seçin (K, S, Y)");
string light = Console.ReadLine();

if (light == "K")
{
    Console.WriteLine("DUR");
}
else if (light == "S")
{
    Console.WriteLine("Dikkat!");
}
else if (light == "Y")
{
    Console.WriteLine("GEÇ");
}
else
{
    Console.WriteLine("Hatalı giriş");
}


switch (light)
{
    case "K":
        Console.WriteLine("DUR");
        break;
    case "S":
        Console.WriteLine("Dikkat");
        break;
    case "Y":
        Console.WriteLine("GEÇ");
        break;
    default:
        Console.WriteLine("Hatalı giriş");
        break;
}

switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
    case DayOfWeek.Saturday:
        Console.WriteLine("Hafta sonu...");
        break;
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
    case DayOfWeek.Thursday:
    case DayOfWeek.Friday:
        Console.WriteLine("Hafta içi...");
        break;

    default:
        break;
}

string dayStateOnAWeek = DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday ? "Hafta sonu" : "Hafta içidir";

