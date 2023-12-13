// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");
Report report = new Report("C:\\test.xslx");
Report htmlReport = new Report("C:\\bididi.xslx", ReportFormat.HTML);
