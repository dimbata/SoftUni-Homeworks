using System;


public class Startup
{
    public static void Main()
    {
        /*
         * Create a program to check if given symbol is digit, vowel or any other symbol
         */

        char input = char.Parse(Console.ReadLine());
        if (input >= 48 && input <= 57)
        {
            Console.WriteLine("digit");
        }
        else if (input == 'a' || input == 'e' || input == 'i' || input == 'u' || input == 'o')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }    

    }
}

