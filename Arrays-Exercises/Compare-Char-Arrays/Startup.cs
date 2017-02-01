namespace Compare_Char_Arrays
{
    using System;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            /*
             * Compare two char arrays lexicographically (letter by letter).
             * Print the them in alphabetical order, each on separate line.
             */

            char[] firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            int shorterArrayLength = Math.Min(firstArray.Length, secondArray.Length);
            bool areEqual = true;

            for (int i = 0; i < shorterArrayLength; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(new string(secondArray));
                    Console.WriteLine(new string(firstArray));
                    areEqual = false;
                    break;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine(new string(firstArray));
                    Console.WriteLine(new string(secondArray));
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine(new string(firstArray));
                    Console.WriteLine(new string(secondArray));
                }
                else
                {
                    Console.WriteLine(new string(secondArray));
                    Console.WriteLine(new string(firstArray));
                }
            }

        }
    }
}
