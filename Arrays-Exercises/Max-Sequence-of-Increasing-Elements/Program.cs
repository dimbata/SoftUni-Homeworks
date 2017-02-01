namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            /*
             * Write a program that finds the longest sequence of equal elements in an array of integers. 
             * If several longest sequences exist, print the leftmost one.
             */

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCount = 1;
            int currentCount = 1;
            int indexToPrint = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                while (numbers[i] < numbers[i + 1])
                {
                    currentCount++;
                    i++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        indexToPrint = i;
                    }
                    if (i == numbers.Length - 1)
                    {
                        break;
                    }
                }
                currentCount = 1;
            }

            for (int i = indexToPrint - maxCount + 1; i < indexToPrint + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
