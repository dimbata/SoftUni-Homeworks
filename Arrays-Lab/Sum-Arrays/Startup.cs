namespace Sum_Arrays
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that reads two arrays of integers and sums them. 
             * When the arrays are not of the same size, 
             * duplicate the smaller array a few times.
             */

            long[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            long[] secondArray = Console
                .ReadLine().Split(' ')
                .Select(long.Parse)
                .ToArray();

            long[] results = SumOfTwoArrays(firstArray, secondArray);

            Console.WriteLine(string.Join(" ", results));
        }

        public static long[] SumOfTwoArrays(long[] firstArray, long[] secondArray)
        {
            int biggerArrayLength = Math.Max(firstArray.Length, secondArray.Length);
            int smallerArrayLength = Math.Min(firstArray.Length, secondArray.Length);
            int firstArrCounter = 0;
            int secondArrCounter = 0;

            long[] results = new long[biggerArrayLength];

            for (int i = 0; (i < firstArray.Length)
                && (firstArrCounter < biggerArrayLength); i++, firstArrCounter++)
            {
                results[firstArrCounter] += firstArray[i];

                if (i == smallerArrayLength - 1 && firstArray.Length == smallerArrayLength)
                {
                    i -= smallerArrayLength;
                }
            }

            for (int i = 0; (i < secondArray.Length)
                && (secondArrCounter < biggerArrayLength); i++, secondArrCounter++)
            {
                results[secondArrCounter] += secondArray[i];

                if (i == smallerArrayLength - 1 && secondArray.Length == smallerArrayLength)
                {
                    i -= smallerArrayLength;
                }
            }

            return results;
        }
    }
}
