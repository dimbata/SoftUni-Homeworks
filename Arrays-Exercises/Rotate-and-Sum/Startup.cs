namespace Rotate_and_Sum
{
    using System;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            /*
             * To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
             * Write a program to read an array of n integers (space separated on a single line) and an integer k, 
             * rotate the array right k times and sum the obtained arrays after each rotation.
             */

            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sums = new int[inputArray.Length];

            for (int i = 0; i < k; i++)
            {
                RotateRight(inputArray, sums);
            }

            Console.WriteLine(string.Join(" ",sums));
        }

        public static int[] RotateRight(int[] array, int[] sums)
        {
            int lastPosition = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastPosition;

            for (int i = 0; i < array.Length; i++)
            {
                sums[i] += array[i];
            }

            return array;
        }
    }
}
