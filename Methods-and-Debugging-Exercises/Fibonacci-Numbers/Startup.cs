namespace Hello_Name
{
    using System;

    public class Startup
    {
        /*  
         *  Define a method Fib(n) that calculates the nth Fibonacci number.
         */

        public static void Main()
        {
            Console.WriteLine(GetFibonacciNumber(Math.Abs(long.Parse(Console.ReadLine()))));
        }

        public static long GetFibonacciNumber(long number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            
            return GetFibonacciNumber(number - 2) + GetFibonacciNumber(number - 1);                      
        }
    }
}
