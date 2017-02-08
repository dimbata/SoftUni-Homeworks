namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that receives some info from the console about people and their phone numbers. 
             * Each entry should have just one name and one number (both of them strings).
             * On each line you will receive some of the following commands:                       
                                      
                   - A {name} {phone} – adds entry to the phonebook. In case of trying to add a name that is already in the
                   
                   phonebook you should change the existing phone number with the new one provided.
                   
                   - S {name} – searches for a contact by given name and prints it in format "{name} -> {number}". In case
                   
                   the contact isn't found, print "Contact {name} does not exist".
                   
                   - END – stop receiving more commands.

             */

            var dictionary = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0]=="A")
                {
                    dictionary[input[1]] = input[2];
                }                
                else if (input[0]=="S" && dictionary.ContainsKey(input[1]))
                {
                    Console.WriteLine($"{input[1]} -> {dictionary[input[1]]}");
                }
                else if (input[0]=="S" && !dictionary.ContainsKey(input[1]))
                {
                    Console.WriteLine($"Contact {input[1]} does not exist.");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
