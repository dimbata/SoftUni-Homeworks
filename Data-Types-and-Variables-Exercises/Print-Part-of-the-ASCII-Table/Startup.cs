using System;

public class Startup
{
    public static void Main()
    {
        /*
         * Find online more information about ASCII (American Standard Code for Information Interchange) 
         * and write a program that prints part of the ASCII table of characters at the console.  
         * On the first line of input you will receive the char index you should start with 
         * and on the second line - the index of the last character you should print.
         */

        int startingPoint = int.Parse(Console.ReadLine());
        int endingPoint = int.Parse(Console.ReadLine());

        for (int counter = startingPoint; counter <= endingPoint; counter++)
        {
            Console.Write((char)counter+" ");
        }
    }
}

