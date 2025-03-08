using TemplateMethodPatternInConsole;
using TemplateMethodPatternInConsole.Abstracts.Concretes;

Console.WriteLine("Same client code can work with different subclasses:");

Client.ClientCode(new ConcreteClass1());

Console.WriteLine("\n");

Console.WriteLine("Same client code can work with different subclasses:");
Client.ClientCode(new ConcreteClass2());