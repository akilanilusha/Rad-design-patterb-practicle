using System;

namespace oopPracticle;

class Animal
{

    public virtual void talk()
    {
        Console.WriteLine("I am Animal");
    }
}

class Dog : Animal
{
    public override void talk()
    {
        Console.WriteLine("I am Dog");
    }

}

class Cat : Animal
{
    public override void talk()
    {
        Console.WriteLine("I am Cat");
    }

}