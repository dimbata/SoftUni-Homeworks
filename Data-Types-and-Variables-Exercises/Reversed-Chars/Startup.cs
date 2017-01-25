using System;



    public class Startup
    {
        public static void Main()
        {
        /*
         * Write a program to ask the user for 3 letters 
         * and print them in reversed order.
         */
        string firstChar = Console.ReadLine();
        string secondChar = Console.ReadLine();
        string thirdChar = Console.ReadLine();
        string output = thirdChar + secondChar + firstChar;
        Console.WriteLine(output);

    }
}

