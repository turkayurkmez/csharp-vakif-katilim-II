// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] citiesInTurkey = { "Ankara", "Eskişehir", "Yozgat", "Bayburt" };
Console.WriteLine("Bir şehir giriniz:");

string status = isCityExistsInCollection(citiesInTurkey, Console.ReadLine()) ? "Var" : "Yok";
Console.WriteLine(status);




bool isCityExistsInCollection(string[] cities, string city)
{
    for (int i = 0; i < cities.Length; i++)
    {
        if (cities[i] == city)
        {
            return true;
        }
    }

    return false;


}

bool isCityExistsInCollectionWithForeach(string[] cities, string city)
{
    foreach (var word in cities)
    {
        if (word == city)
        {
            return true;
        }
    }

    return false;


}