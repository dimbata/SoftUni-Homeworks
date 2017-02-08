namespace Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program to read an array of integers and 
             * condense them by summing adjacent couples of elements until a single integer is obtained. 
             * For example, if we have 3 elements {2, 10, 3}, 
             * we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, 
             * then we sum again all adjacent elements and obtain {12+13} = {25}.
             */

            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long[] condensed = CondenseArray(numbers);

            Console.WriteLine(string.Join(" ",condensed));
        }

        public static long[] CondenseArray(long[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            long[] condensed = new long[array.Length - 1];

            while (array.Length != 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {                    
                    condensed[i] = array[i] + array[i + 1];                    
                }

                array = condensed;
                condensed = new long[array.Length - 1];
            }

            return array;
        }
    }
}
