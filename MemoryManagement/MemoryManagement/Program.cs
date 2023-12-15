// See https://aka.ms/new-console-template for more information
using MemoryManagement;

Console.WriteLine(GC.GetTotalMemory(true));
decimal value = 0.0000000000000000000000000000000000001M;

Console.WriteLine($" decimal tanımlandıktan sonra:  {GC.GetTotalMemory(true)}");

var words = new string[1000000];
Console.WriteLine($" yüz bin elemanlı array tanımlandıktan sonra:  {GC.GetTotalMemory(true)}");

sample();

Console.WriteLine($" sample fonksiyonu çağrıldıktan sonra:  {GC.GetTotalMemory(true)}");
GC.Collect();
words = null;
Console.WriteLine($" Çöp toplandıktan sonra:  {GC.GetTotalMemory(true)}");

//Console.WriteLine(GC.GetTotalAllocatedBytes(true));

void sample()
{
    var words = new Product[1000000];
    Console.WriteLine($" yüz bin elemanlı product array fonksiyon içinde:  {GC.GetTotalMemory(true)}");

}

using (ReportRecorder recorder = new ReportRecorder("C:\\Users\\turka\\Videos\\Logitech\\LogiCapture\\a.txt"))
{

    recorder.Dispose();
}