namespace A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource
             *
             * (e.g. Gold, Silver, Copper, and so on), and every even – quantity. Your task is to collect the resources and print them
             * 
             * each on a new line.
             * 
             * Print the resources and their quantities in format:
             * 
             * {resource} –> {quantity}
             * 
             * The quantities inputs will be in the range [1 … 2 000 000 000]
             */

            Dictionary<string, long> dict = new Dictionary<string, long>();
            int counter = 1;
            string input = string.Empty;

            while (true)
            {
                if (counter % 2 == 1)
                {
                    input = Console.ReadLine();
                    if (input=="stop")
                    {
                        break;
                    }

                    if (!dict.ContainsKey(input))
                    {
                        dict[input] = 0;
                    }
                }
                else
                {
                    dict[input] += int.Parse(Console.ReadLine());
                }

                counter++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
