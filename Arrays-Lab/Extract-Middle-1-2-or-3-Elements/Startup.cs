﻿namespace Extract_Middle_1_2_or_3_Elements
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
             *   •	n = 1 -> 1 element
             *   •	even n -> 2 elements
             *   •	odd n -> 3 elements
             *   Create a program that reads an array of integers (space separated values) 
             *   and prints the middle elements.
             */

            long[] arrayInput = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long[] extractedNumbers = ExtractMiddleNumbers(arrayInput);

            Console.WriteLine("{ " + string.Join(", ", extractedNumbers) + " }");
        }

        public static long[] ExtractMiddleNumbers(long[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            else if (array.Length % 2 == 0)
            {
                return new long[] { array[(array.Length / 2) - 1], array[array.Length / 2] };
            }
            else
            {
                return new long[] { array[(array.Length / 2) - 1], array[array.Length / 2], array[(array.Length / 2) + 1] };
            }
        }
    }
}
