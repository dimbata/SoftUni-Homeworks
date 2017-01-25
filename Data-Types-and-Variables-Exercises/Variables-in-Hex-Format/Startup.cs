using System;



class Startup
{
    static void Main()
    {
        /*
         * Write a program that reads a number in hexadecimal format (0x##) 
         * convert it to decimal format and prints it.
         */

        int number = Convert.ToInt32(Console.ReadLine(), 16);
        
        Console.WriteLine(number);
        
    }
}
