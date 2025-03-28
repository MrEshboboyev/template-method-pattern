﻿namespace TemplateMethodPatternInConsole.Abstracts;

// The AbstractClass class is the base class that contains a skeleton of 
// some algorithm, composed of calls to (usually) abstract primitive
// operations.
//  Concrete subclasses should implement these operations, but
// leave the structure of the algorithm itself intact.
public abstract class AbstractClass
{
    // The template method defines the skeleton of an algorithm.
    public void TemplateMethod()
    {
        BaseOperation1();
        RequiredOperation1();
        BaseOperation2();
        Hook1();
        RequiredOperation2();
        BaseOperation3();
        Hook2();
    }

    // These operations have to be implemented in subclasses.
    protected void BaseOperation1()
    {
        Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
    }

    protected void BaseOperation2()
    {
        Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
    }

    protected void BaseOperation3()
    {
        Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
    }

    // These operations have to be implemented in subclasses.
    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    // These are "hooks." Subclasses may override them, but it's not mandatory
    // since the hooks already have default (but empty) implementation. Hooks
    // provide additional extension points in some crucial places of the
    // algorithm.

    protected virtual void Hook1() { }

    protected virtual void Hook2() { }
}