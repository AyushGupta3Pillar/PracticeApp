using System;

public class PallindromeString
{
    public void pallindromeString()
    {
        Console.WriteLine("Enter the string to check the pallindrome");
        string name = Console.ReadLine();
        string temp = "";

        for(int i= name.Length - 1; i >= 0; i--)
        {
            temp+= name[i];
        }

        if(temp == name)
        {
            Console.WriteLine($"{name} is pallindrome");
        }
        else
        {
            Console.WriteLine($"{name} is not pallindrome");
        }
    }
}