// See https://aka.ms/new-console-template for more information

using System.Collections.ObjectModel;
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");
List<string> countries = new List<string>();
countries.Add("Türkiye");


//ArrayList arrayList = new ArrayList();

//FIFO ve LIFO
Queue<string> mails = new Queue<string>();
mails.Enqueue("turkay.urkmez@dinamikzihin.com");
mails.Enqueue("zeynep.aygul@vakifkatilim.com.tr");
mails.Enqueue("merve.akyel@vakifkatilim.com.tr");

while (mails.Count > 0)
{
    string mail = mails.Dequeue();
    Console.WriteLine(mail);
}

Stack<string> stackString = new Stack<string>();
stackString.Push("A");
stackString.Push("B");
stackString.Push("C");

while (stackString.Count > 0)
{
    Console.WriteLine(stackString.Pop());

}


//Dictionary: key-value
Dictionary<string, string> plates = new Dictionary<string, string>();

string plateCode = string.Empty;
do
{
    Console.WriteLine("Plaka giriniz (Çıkmak için q)");
    plateCode = Console.ReadLine();
    if (plateCode == "q")
    {
        break;
    }
    else
    {
        Console.WriteLine("il adını girin");
        var city = Console.ReadLine();
        if (plates.ContainsKey(plateCode))
        {
            Console.WriteLine("Bu plaka zaten var");
        }
        else
        {
            plates.Add(plateCode, city);
        }
    }
} while (plateCode != "q");

Console.WriteLine("Plaka kodunu girin:");
var code = Console.ReadLine();
var cityName = code == string.Empty ? "kod girilmedi" : plates[code];
Console.WriteLine($"{code} plaka kodlu şehir: {cityName}");

foreach (var entry in plates)
{
    Console.WriteLine($"{entry.Key} : {entry.Value}");
}

//KeyValuePair<string, string> keyValue = new KeyValuePair<string, string>("34","İstanbul");

ObservableCollection<int> numbers = new ObservableCollection<int>();
numbers.CollectionChanged += Numbers_CollectionChanged;

numbers.Add(15);
numbers.Add(35);
numbers.Add(22);
numbers.Add(13);

numbers[3] = 8;

numbers.Remove(22);






void Numbers_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            Console.WriteLine($"{e.NewItems[0]} sayısı eklendi");
            break;
        case NotifyCollectionChangedAction.Remove:
            Console.WriteLine($"{e.OldItems[0]} sayısı çıkarıldı. Eski index'i: {e.OldStartingIndex} ");

            break;
        case NotifyCollectionChangedAction.Replace:
            Console.WriteLine($"{e.OldItems[0]}, {e.NewItems[0]} sayısıyla değiştirildi");

            break;
        case NotifyCollectionChangedAction.Move:
            break;
        case NotifyCollectionChangedAction.Reset:
            break;
        default:
            break;
    }
}