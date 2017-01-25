using System;



public class Startup
{
    public static void Main()
    {
        /*
         * Write a program that reads a string, converts it to Boolean variable 
         * and prints “Yes” if the variable is true and “No” if the variable is false.
         * 
         */

        bool input = bool.Parse(Console.ReadLine());
        if (input)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

