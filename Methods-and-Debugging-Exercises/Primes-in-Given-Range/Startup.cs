namespace Hello_Name
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {

            /*
             * Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
             */

            List<long> primeNumbers = FindPrimesInRange(Math.Abs(long.Parse(Console.ReadLine())), Math.Abs(long.Parse(Console.ReadLine())));

            Console.WriteLine(string.Join(", ",primeNumbers).TrimEnd(','));
        }

        public static List<long> FindPrimesInRange(long startNumber, long endNumber)
        {
            List<long> result = new List<long>();

            for (long i = startNumber; i < endNumber; i++)
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