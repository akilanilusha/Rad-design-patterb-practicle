using System;

namespace oopPracticle;

public class Person
{
    public int id;
    private int health = 100;

    public int age { get; set; }
 
    public Person(int id)
    {
        this.id = id;
    }

    public int GeHealth()
    {
        return health;
    }

    public void SetHealth(int health)
    {
        if (health < 0)
        {
            Console.WriteLine("Health cannot be negative.");
            return;
        }
        this.health = health;
    }
    public void SayHi()
    {
        Console.WriteLine("Say Hi");
        Console.ReadKey();
    }
}
