// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//.NET 1.0
var result = FilterHelper.Filter(numbers, evenNumbers);

//.NET 2.0

var multipleThree = FilterHelper.Filter(numbers,
delegate (int num)
{
    return num % 3 == 0;
});

//.NET 3.5:

var bigThanFive = FilterHelper.Filter(numbers, n => n > 5);



showResult(result);
Console.WriteLine("============== Üç ve üçün katları ============");
showResult(multipleThree);
Console.WriteLine("============== 5'den büyük olanlar ============");
showResult(bigThanFive);




void showResult(int[] result)
{
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}

void showResultWithAction(int[] result)
{
    result.ToList().ForEach(number => Console.WriteLine(number));
}

//Amaç: verilen int[] içerisinden kurala uyan sayıları döndürmeniz gerek
//int[] filter(int[] numbers)
//{
//    List<int> result = new List<int>();
//    foreach (var item in numbers)
//    {
//        if (oddNumbers(item))
//        {
//            result.Add(item);
//        }
//    }

//    return result.ToArray();
//}

bool evenNumbers(int item)
{
    return item % 2 == 0;
}
bool oddNumbers(int item)
{
    return item % 2 == 1;
}
