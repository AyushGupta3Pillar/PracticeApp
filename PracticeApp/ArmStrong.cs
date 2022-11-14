using System;

public class ArmStrong
{
    public void armstrong()
    {
        Console.WriteLine("Enter the number :");
        int number = int.Parse(Console.ReadLine());
        int rem , sum=0;
        int temp = number;

        while (number > 0)
        {
            rem = number % 10;
            sum = sum + (rem*rem*rem);
            number = number / 10;
        }

        if (temp == sum)
        {
            Console.WriteLine($"Number {temp} is armstrong");
        }

        else
        {
            Console.WriteLine($"Number {temp} is not armstrong");
        }
    }
}