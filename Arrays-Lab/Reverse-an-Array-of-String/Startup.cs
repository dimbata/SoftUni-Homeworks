namespace Day_of_Week
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program to read an array of strings, reverse it and print its elements. 
             * The input consists of a sequence of space separated strings. 
             * Print the output on a single line (space separated).
             */

            string[] arrayOfStrings = Console.ReadLine().Split(' ');

            for (int i = 0; i < arrayOfStrings.Length / 2; i++)
            {
                string tempHolder = arrayOfStrings[i];
                arrayOfStrings[i] = arrayOfStrings[arrayOfStrings.Length - 1 - i];
                arrayOfStrings[arrayOfStrings.Length - 1 - i] = tempHolder;
            }

            Console.WriteLine(string.Join(" ",arrayOfStrings));
        }
    }
}