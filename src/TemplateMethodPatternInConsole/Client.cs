using TemplateMethodPatternInConsole.Abstracts;

namespace TemplateMethodPatternInConsole;

public class Client
{
    // The Client code calls the template method to execute the algorithm. Client
    // code does not have to know the concrete class of an object it works with, as
    // long as it works with objects through the interface of their base class.
    public static void ClientCode(AbstractClass abstractClass)
    {
        // ...
        abstractClass.TemplateMethod();
        // ...
    }
}