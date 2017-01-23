using System;



public class SpecialNumbers
{
    public static void Main()
    {
        /*
         * A number is special when its sum of digits is 5, 7 or 11.
            Write a program to read an integer n and for all numbers 
            in the range 1…n to print the number and if it is
            special or not (True / False).
         */

        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(DigitSum(input));


    }
    public static int DigitSum(int numberToBeProcessed)
    {
        int sum = 0;
        while (true)
        {
            sum += numberToBeProcessed % 10;
            numberToBeProcessed /= 10;
            if (numberToBeProcessed == 0)
            {
                break;
            }
        }
        if (sum > 9)
        {
            sum = DigitSum(sum);

        }
        return sum;

    }
}

