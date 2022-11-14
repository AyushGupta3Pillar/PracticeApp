using System;

class PracticeApp
{
    string color = "Pink";

    static void Main(String[] args)
    {
        // PracticeApp house = new PracticeApp();
        //Console.WriteLine(house.color);

        // access modifier

        /*Bike bike = new Bike();
        Console.WriteLine(bike.brand);
        Console.WriteLine(bike.milege);
        Console.WriteLine(bike.color);*/

        // encapsulation

        /*Employee employee = new Employee();
        employee.Name = "David";                 
        Console.WriteLine(employee.Name);*/

        // inheritence   // if we can use sealed keyword then we can't inherit that class

        /* Son son = new Son();

         son.restaurant();

         Console.WriteLine(son.worth + "...." + son.new_worth);*/


        // polymorphism

        Polymorphism poly = new Polymorphism();



        Console.WriteLine(poly.sound());
        Console.ReadLine();


        // abstraction

        //Animals animal = new Animals();

        /*Dogs dog = new Dogs();
        dog.sound();
        dog.legs();*/


        /*Pallindrome pallindrome = new Pallindrome();
        pallindrome.pallindrome();*/


        /*PallindromeString pallindromeString = new PallindromeString();
        pallindromeString.pallindromeString();*/

        /*Fibonacci fibonacci = new Fibonacci();
        fibonacci.fibonacci();*/

        /*SumOfDigits sum = new SumOfDigits();
        sum.sumofDigits();*/

        /*Factorial factorial = new Factorial();
        factorial.factorial();*/

        /*DecimalToBinary decimalToBinary = new DecimalToBinary();
        decimalToBinary.decimaltobinary();*/

        /*ArmStrong armStrong = new ArmStrong();
        armStrong.armstrong();*/

        /*Factors factors = new Factors();
        factors.factors();*/
    }
}