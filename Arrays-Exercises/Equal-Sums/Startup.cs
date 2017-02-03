namespace Equal_Sums
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that determines if there exists an element in the array 
             * such that the sum of the elements on its left is equal to the sum of the elements on its right. 
             * If there are no elements to the left / right, their sum is considered to be 0.
             *  Print the index that satisfies the required condition or “no” if there is no such index.
             */

            int[] arrayInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool foundEqual = false;

            if (arrayInput.Length == 1)
            {
                Console.WriteLine(0);
                foundEqual = true;
            }
            else
            {
                for (int i = 1; i < arrayInput.Length; i++)
                {
                    if (SumOfNumbersRightAndLeft(arrayInput, i))
                    {
                        Console.WriteLine(i);
                        foundEqual = true;                       
                    }
                }
            }

            if (!foundEqual)
            {
                Console.WriteLine("no");
            }
        }

        public static bool SumOfNumbersRightAndLeft(int[] array, int index)
        {
            long sumRight = 0;
            long sumLeft = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                sumRight += array[i];
            }

            for (int i = 0; i < index; i++)
            {
                sumLeft += array[i];
            }

            if (sumLeft == sumRight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
