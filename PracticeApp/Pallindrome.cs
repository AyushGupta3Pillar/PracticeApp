using System;

public class Pallindrome
{
    public void pallindrome()
    {
        Console.WriteLine("Enter the number to check pallindrome :");
        int number = int.Parse(Console.ReadLine());
        int rem, sum = 0;
        int temp = number;

        while (number > 0)
        {
            rem = number % 10;

            sum = (sum *10) + rem;

            number = number / 10;

        }

        if ( temp == sum )
        {
            Console.WriteLine($"Number {temp} is Pallindrome");
        }
        else
        {
            Console.WriteLine($"Number {temp} is not Pallindrome");
        }
    }
}