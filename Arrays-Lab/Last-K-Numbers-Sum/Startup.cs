namespace Day_of_Week
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Enter two integers n and k. Generate and print the following sequence of n elements:
             * •	The first element is: 1
             * •	All other elements = sum of the previous k elements (if less than k are available, sum all of them)
             */

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequences = new long[n];

            sequences[0] = 1;

            for (int i = 1; i < n; i++)
            {
                sequences[i] = SumOfNumsInArray(sequences, i, k);
            }

            Console.WriteLine(string.Join(" ",sequences));
        }

        public static long SumOfNumsInArray(long[] array, int index, int count)
        {
            long sum = 0;
            if (index - count > 0)
            {
                for (int i = index; i > index - count; i--)
                {
                    sum += array[i-1];
                }
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}
