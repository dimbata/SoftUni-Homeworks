﻿namespace A_Miner_Task
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

            Dictionary<string, string> dict = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                                
                if (!(email.ToLower().EndsWith("us") || email.ToLower().EndsWith("uk")))
                {
                    dict.Add(name, email);
                }

                name = Console.ReadLine();
            }
    
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
