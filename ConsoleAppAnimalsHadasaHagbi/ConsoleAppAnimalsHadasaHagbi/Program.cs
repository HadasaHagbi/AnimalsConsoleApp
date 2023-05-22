// See https://aka.ms/new-console-template for more information
using ConsoleAppAnimalsHadasaHagbi.Classes;

Console.WriteLine("I: Hello, Dog!");
Dog d = new Dog(true, true, 2);
Console.Write("Dog: ");
d.sayHello();
d.sayHello(1);
d.setMammals(true);
Console.WriteLine("isCarnivorous: " + d.isCarnivorous());
Console.WriteLine("isMammals: " + d.isMammals());
Console.WriteLine("==================");

Cat c=new Cat(true, true, 2);
Console.WriteLine("Hello, Cat!");
Console.Write("Cat: ");
c.sayHello();
c.sayHello(1);
c.sayHello(2);
c.setMammals(true);
Console.WriteLine("isCarnivorous: " + c.isCarnivorous());
Console.WriteLine("isMammals: " + c.isMammals());
Console.WriteLine("==================");
