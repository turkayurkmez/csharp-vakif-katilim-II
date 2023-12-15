// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

showAllMethodsInType(typeof(string));
Console.WriteLine("............");
showAllMethodsInType(typeof(Random));


void showAllMethodsInType(Type type)
{
    Console.WriteLine($"======= {type.Name} tipinin metotları ======  ");
    type.GetMethods().ToList().ForEach(m => Console.WriteLine($"{m.Name} {m.ReturnType} ({string.Join(',', m.GetParameters().Select(p => p.ParameterType + " " + p.Name))})"));
}