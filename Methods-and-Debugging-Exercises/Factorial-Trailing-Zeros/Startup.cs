namespace Longer_Line
{
    using System;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create a program that counts the trailing zeroes of the factorial of a given number.
             */

            int number = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(number);
            int numZeroes = CountTrailingZeroes(result);

            Console.WriteLine(numZeroes);
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

        public static int CountTrailingZeroes(BigInteger number)
        {
            int count = 0;

            while (number % 10 == 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }
    }
}