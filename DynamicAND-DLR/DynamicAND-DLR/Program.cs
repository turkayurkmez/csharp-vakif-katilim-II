// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

dynamic d = "deneme";
Console.WriteLine(d.YokBoyleFonksiyon());
dynamic output = getAnonymType();
Console.WriteLine(output.Ad);
sample("merhaba");





dynamic getAnonymType()
{
    return new { Ad = "Aşık", Soyad = "Veysel" };
}


void sample(dynamic dinamik)
{
    Console.WriteLine(dinamik);
}
