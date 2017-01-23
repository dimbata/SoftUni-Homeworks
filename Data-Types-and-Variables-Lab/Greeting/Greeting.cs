using System;


namespace Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            /*Write a program that enters first name, last name and age and prints 
              "Hello, <firstName> <lastName>. You are <age> years old.".
             Use interpolated strings.              
             */

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            // We don't parse the age to an int, because we currently don't need to perfom mathematical operations with it.
            string age = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");


        }
    }
}
