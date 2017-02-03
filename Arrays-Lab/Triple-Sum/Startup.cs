namespace Day_of_Week
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program to read an array of integers and find all triples of elements a, b and c, 
             * such that a + b == c (where a stays left from b). 
             * Print “No” if no such triples exist.
             */

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool foundSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers.Contains(numbers[i] + numbers[j]))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[i] + numbers[j]}");
                        foundSum = true;
                    }
                }
            }

            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}