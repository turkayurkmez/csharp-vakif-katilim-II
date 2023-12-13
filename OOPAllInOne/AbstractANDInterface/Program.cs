// See https://aka.ms/new-console-template for more information
using AbstractANDInterface;

Console.WriteLine("Hello, World!");
PdfDocument pdf = new PdfDocument();
ExcelDocument excel = new ExcelDocument();
WordDocument word = new WordDocument();

DocumentPrinter documentPrinter = new DocumentPrinter();
documentPrinter.Print(excel);
documentPrinter.Print(word);
//documentPrinter.Print(pdf);