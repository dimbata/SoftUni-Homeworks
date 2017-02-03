namespace Multiply_Evens_by_Odds
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create a program that reads an integer number and multiplies
             *  the sum of all its even digits by the sum of all its odd digits
             */

            long number = Math.Abs(long.Parse(Console.ReadLine()));

            int sumEvens = 0;
            int sumOdds = 0;

            foreach (var item in number.ToString())
            {
                if ((item - '0') % 2 == 0)
                {
                    sumEvens += item - '0';
                }
                else
                {
                    sumOdds += item - '0';
                }
            }

            Console.WriteLine(sumOdds*sumEvens);
        }
    }
}
