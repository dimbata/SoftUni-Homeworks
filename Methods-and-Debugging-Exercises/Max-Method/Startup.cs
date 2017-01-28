namespace Hello_Name
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create a method GetMax(int a, int b), that returns maximal of two numbers. 
             * Write a program that reads three numbers from the console and prints the biggest of them. 
             * Use the GetMax(…) method you just created.
             */

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetMax(firstNumber, GetMax(secondNumber, thirdNumber));

            Console.WriteLine(result);
        }

        public static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }

            return second;
        }
    }
}