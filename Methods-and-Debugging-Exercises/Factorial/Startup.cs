namespace Longer_Line
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that calculates and prints the n! for any n in the range [1…1000].
             */

            BigInteger result = Factorial(int.Parse(Console.ReadLine()));

            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}