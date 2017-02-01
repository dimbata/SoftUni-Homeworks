namespace Sign_of_Integer_Number
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create a method that prints the sign of an integer number n.
             */

            long numberInput = long.Parse(Console.ReadLine());

            PrintSign(numberInput);
        }

        public static void PrintSign(long number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive..");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
