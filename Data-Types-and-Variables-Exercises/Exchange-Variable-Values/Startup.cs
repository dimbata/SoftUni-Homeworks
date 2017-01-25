using System;



public class Startup
{
    public static void Main()
    {
        /*
         * Declare two integer variables a and b and assign them with 5 and 10 
         * and after that exchange their values by using some programming logic. 
         * 
         */

        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}",a);
        Console.WriteLine("b = {0}",b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);

    }
}

