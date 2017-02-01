namespace Fold_and_Sum
{
    using System;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            /*
             * Read an array of 4*k integers, fold it 
             * and print the sum of the upper and lower two rows 
             * (each holding 2 * k integers):
             */

            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = inputArray.Length / 4;
            int[] sums = new int[2 * k];
            int[] firstRow = new int[2 * k];
            int[] secondRow = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = inputArray[k - 1 - i];
                firstRow[k + i] = inputArray[(4 * k) - 1 - i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                secondRow[i] = inputArray[k + i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                sums[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ",sums));
        }
    }
}
