using System;

public class Startup
{
    public static void Main()
    {
        /*
         * Create a program to convert a decimal number to hexadecimal and binary number and print it.
         */

        int input = int.Parse(Console.ReadLine());
        string hexConversion = Convert.ToString(input, 16).ToUpper();
        string binaryConversion = Convert.ToString(input, 2);
        Console.WriteLine(hexConversion);
        Console.WriteLine(binaryConversion);
    }
}

