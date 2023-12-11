// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Sayısal
 *   -Tam sayı
 *     
 *   -Ondalıklı sayı
 * 
 * Sözel
 *   - Tek karakter
 *   - Çok karakter
 * 
 * Mantıksal
 *  
 * 
 * 
 */

byte eightBit = 255;
sbyte negativeEight = -8;

short sixteenBit = 32767;
ushort justPositive = 65535;

int integerValue = 0;
long longValue = 0;

//ondalıklı
double dPi = 3.14d;
float fPi = 3.14f;
decimal decPi = 31554557414569897.14591515674459744668774466777444577744598980m;


/*Sözel
 * -Tek karakter
 * -Çok karakter
 */

char c = '{';
string stringValue = "Vakıf katılım";

bool isOk = true;



try
{
    Console.WriteLine("Bir sayı girin:");
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Bir sayı daha girin:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int total = number1 + number2;
    checked
    {
        byte bTotal = (byte)total;
        Console.WriteLine(bTotal);
    }
}
catch (OverflowException)
{

    Console.WriteLine("Girdiğiniz sayılar toplamı byte tipine dönüşmüyor!");
}
catch (FormatException)
{
    Console.WriteLine("Girdiğiniz veriler sayısal olmalı!");
}








