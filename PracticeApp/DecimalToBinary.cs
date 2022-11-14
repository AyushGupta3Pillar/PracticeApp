using System;

public class DecimalToBinary
{
    public void decimaltobinary()
    {
        Console.WriteLine("Enter the number :");
        int number = int.Parse(Console.ReadLine());

        int i;
        int[] arr = new int[number];

        for(i = 0; number > 0; i++)
        {
            arr[i] = number % 2;
            number /= 2;
        }

        Console.WriteLine("Binary Representation of number is : ");
        for(i= i - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
    }
}