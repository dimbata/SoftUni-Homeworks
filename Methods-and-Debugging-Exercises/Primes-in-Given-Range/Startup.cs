namespace Hello_Name
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {

            /*
             * Write a method that calculates all prime numbers in given range and returns them as list of integers.
             * Write a method to print a list of integers. 
             * Write a program that enters two integer numbers (each at a separate line) 
             * and prints all primes in their range, separated by a comma.
             */

            List<long> primeNumbers = FindPrimesInRange(Math.Abs(long.Parse(Console.ReadLine())), Math.Abs(long.Parse(Console.ReadLine())));

            Console.WriteLine(string.Join(", ",primeNumbers).TrimEnd(','));
        }

        public static List<long> FindPrimesInRange(long startNumber, long endNumber)
        {
            List<long> result = new List<long>();

            for (long i = startNumber; i <= endNumber; i++)
            {
                if (CheckIfPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;                  
        }

        public static bool CheckIfPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
 