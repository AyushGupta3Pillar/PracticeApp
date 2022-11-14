using System;

public class Factorial
{
    public void factorial()
    {
        Console.WriteLine("Enter the number to find the factorial");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;
        
        for(int i=1 ; i<=number; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine($"Factorial of {number} is : {factorial}");
    }
}