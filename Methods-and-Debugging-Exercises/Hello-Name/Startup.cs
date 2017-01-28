namespace Hello_Name
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
             */

            PrintName(Console.ReadLine());
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
