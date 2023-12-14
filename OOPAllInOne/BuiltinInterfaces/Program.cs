// See https://aka.ms/new-console-template for more information
using BuiltinInterfaces;

Console.WriteLine("Hello, World!");

Student student1 = new Student() { Id = 1, Name = "Türkay", Score = 75 };
Student student2 = new Student() { Id = 2, Name = "Sinem", Score = 95 };

ClassRoom classRoom = new ClassRoom();
classRoom.AddStudent(student1);
classRoom.AddStudent(student2);

classRoom.SortStudents();
foreach (var item in classRoom)
{
    Console.WriteLine(item);
}