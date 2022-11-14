using System;

class Polymorphism
{
    public virtual string sound()
    {
        return "Animal Makes sound";
        
    }
}

class Dog : Polymorphism
{
    public override string sound()
    {
        return "Dog barks" ;
    }
}

class Cat : Polymorphism
{
    public override string sound()
    {
        return "Cat meow";
    }
}