﻿namespace TemplateMethodPatternInConsole.Abstracts.Concretes;

// Concrete classes have to implement all abstract operations of the base class.
// They can also override some operations with a default implementation.
public class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
    }
}