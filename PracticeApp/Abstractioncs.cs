using System;


abstract class Animals
{
    public abstract void sound();

    public void legs()
    {
        Console.WriteLine("Animal have 4 legs");
    }
}

class Dogs : Animals
{
    public override void sound()
    {
        Console.WriteLine("The dog barks");
    }
}