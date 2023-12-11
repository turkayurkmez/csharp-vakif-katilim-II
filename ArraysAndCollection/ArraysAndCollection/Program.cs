// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string[] participants = new string[] { "Erdem Kozluk", "Serdal Koruk", "Ebrar Tepeciklioğlu" };
int[] weathers = new int[5];

weathers[0] = 15;
weathers[1] = 10;
weathers[2] = 5;
weathers[3] = 1;

Console.WriteLine(participants[participants.Length - 1]);

//42
//Kırk iki

//string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
//string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

do
{
    Console.WriteLine("Bir sayı giriniz");
    int number = int.Parse(Console.ReadLine());
    string word = numberToWord(number);
    Console.WriteLine("Bir sayı daha girmek ister misin (E/H)? ");
} while (Console.ReadLine() == "E");

for (int i = 1; i < 100; i++)
{
    string word = numberToWord(i);
    Console.WriteLine(word);
}

List<string> participantList = new List<string>();
participantList.Add("Murat Albayraklıoğlu");





string numberToWord(int number)
{
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

    int onlarBasamagindakiDeger = number / 10;
    int birlerBasamagindakiDeger = number % 10;
    string word = onlar[onlarBasamagindakiDeger] + " " + birler[birlerBasamagindakiDeger];
    return word;
}