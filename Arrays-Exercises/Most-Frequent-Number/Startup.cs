namespace Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that finds the most frequent number in a given sequence of numbers.
             * • Numbers will be in the range [0…65535].
             * • In case of multiple numbers with the same maximal frequency, print the leftmost of them.
             */

            List<int> listOfNums = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToList();
            
            int mode = listOfNums.GroupBy(v => v)
             .OrderByDescending(g => g.Count())
             .First()
             .Key;

            Console.WriteLine(mode);
        }
    }
}
