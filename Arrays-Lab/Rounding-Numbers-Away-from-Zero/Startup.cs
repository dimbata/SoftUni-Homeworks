namespace Day_of_Week
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program to read an array of real numbers (space separated values), 
             * round them to the nearest integer in “away from 0” style and print the output.
             */

            double[] arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine($"{arrayOfNumbers[i]} => {Math.Round(arrayOfNumbers[i], MidpointRounding.AwayFromZero)}");                
            }           
        }
    }
}