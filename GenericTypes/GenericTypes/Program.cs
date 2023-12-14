// See https://aka.ms/new-console-template for more information
using GenericTypes;

Console.WriteLine("Hello, World!");
//boxing
object o = 9;
//unboxing
string s = (string)o;

int result = (int)sampleMethod(8);

PointGeneral pointGeneral = new PointGeneral();
pointGeneral.X = 10;
pointGeneral.Y = 11;

GenericPoint<decimal> decimalGp = new GenericPoint<decimal>();
decimalGp.X = 10.6M;
decimalGp.Y = 0.00000000001M;


object sampleMethod(object o)
{
    return o;
}

static string show<T>(T t) where T : class
{
    return t.ToString();
}