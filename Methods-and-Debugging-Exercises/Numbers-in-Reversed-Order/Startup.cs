namespace Hello_Name
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a method that prints the digits of a given decimal number in a reversed order.
             */

            Console.WriteLine(ReverseDigits(double.Parse(Console.ReadLine())));
        }

        public static string ReverseDigits(double number)
        {
            var result = number.ToString().ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}