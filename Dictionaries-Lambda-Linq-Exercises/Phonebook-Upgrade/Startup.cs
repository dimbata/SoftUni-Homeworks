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
             * Add functionality to the phonebook from the previous task
             *  to print all contacts ordered lexicographically when
             * receive the command “ListAll”.
             */

            var dictionary = new SortedDictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "A")
                {
                    dictionary[input[1]] = input[2];
                }
                else if (input[0] == "S" && dictionary.ContainsKey(input[1]))
                {
                    Console.WriteLine($"{input[1]} -> {dictionary[input[1]]}");
                }
                else if (input[0] == "S" && !dictionary.ContainsKey(input[1]))
                {
                    Console.WriteLine($"Contact {input[1]} does not exist.");
                }
                else if (input[0]=="ListAll")
                {
                    ListAll(dictionary);
                }
                else
                {
                    break;
                }
            }            
        }

        public static void ListAll(SortedDictionary<string,string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}