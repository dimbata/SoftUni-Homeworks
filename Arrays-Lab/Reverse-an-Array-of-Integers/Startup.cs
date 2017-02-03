namespace Day_of_Week
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program to read an array of integers, reverse it and print its elements. 
             * The input consists of a number n (the number of elements) + n integers, each as a separate line. 
             * Print the output on a single line (space separated).
             */

            int n = int.Parse(Console.ReadLine());

            int[] arrayOfNums = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayOfNums[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arrayOfNums);

            Console.WriteLine(string.Join(" ",arrayOfNums));
        }
    }
}