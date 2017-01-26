using System;

public class Startup
{
    public static void Main()
    {
        /*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
         * Note that we cannot directly compare two floating-point numbers a and b 
         * by a==b because of the nature of the floating-point arithmetic. 
         * Therefore, we assume two numbers are equal if they are more closely to each other 
         * than some fixed constant eps.
         */

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (Math.Abs(firstNumber-secondNumber)<=eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}

