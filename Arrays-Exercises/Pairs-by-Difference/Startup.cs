namespace Pairs_by_Difference
{
    using System;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that count the number of pairs in given array which difference is equal to given number.
             *  Input
             *  •	The first line holds the sequence of numbers.
             *  •	The second line holds the difference.
             */

            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int differences = 0;
            

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j] + difference || inputArray[i] == inputArray[j] - difference)
                    {
                        differences++;                        
                    }
                }
            }

            Console.WriteLine(differences);            
        }
    }
}
