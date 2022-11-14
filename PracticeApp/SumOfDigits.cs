using System;

public class SumOfDigits
{
    public void sumofDigits()
    {
        Console.WriteLine("Enter the number :");
        int  number = int.Parse(Console.ReadLine());
        int sum = 0, rem;

        while(number > 0)
        {
            rem = number % 10;
            sum = sum + rem;
            number = number / 10;
        }

        Console.WriteLine($"The sum of Digits is : {sum}");
    }
}