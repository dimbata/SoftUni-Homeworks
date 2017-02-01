namespace Largest_Common_End
{
    using System;

    public class Startup
    {
        static void Main()
        {
            /*
             * Read two arrays of words and find the length of the largest common end (left or right).
             */

            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int largestCommonEnd = 0;
            int largestCommonBeginning = 0;

            int shorterArrayLength = Math.Min(firstArray.Length, secondArray.Length);


            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    largestCommonEnd++;                                        
                }
            }

            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    largestCommonBeginning++;                   
                }
            }

            Console.WriteLine(Math.Max(largestCommonBeginning, largestCommonEnd));

        }
    }
}
