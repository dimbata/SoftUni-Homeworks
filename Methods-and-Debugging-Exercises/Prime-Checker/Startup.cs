namespace Hello_Name
{
    using System;

    public class Startup
    {
        public static void Main()
        {

            /*
             * Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
             */

            Console.WriteLine(CheckIfPrime(long.Parse(Console.ReadLine())));
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