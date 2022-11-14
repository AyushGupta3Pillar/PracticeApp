using System;

public class Factors
{
    public void factors()
    {
        Console.WriteLine("Enter the number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The factors of {number} is : ");

        for(int i=1;i  <= number; i++)
        {
            if(number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}