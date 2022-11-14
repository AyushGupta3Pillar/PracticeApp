using System;

public class Fibonacci
{
    public void fibonacci()
    {
        int first_number = 0, second_number = 1;
        Console.WriteLine("Enter the number of element you want to print: ");
        int element = int.Parse(Console.ReadLine());

        if( element < 2)
        {
            Console.WriteLine("Element should be greater than 2");
        }

        else
        {
            Console.Write(first_number + " "+ second_number + " ");

            for( int i=2 ; i<element; i++)
            {
                int next = first_number+ second_number;
                Console.Write(next+ " ");
                first_number = second_number;
                second_number = next;
            }
        }
    }
}