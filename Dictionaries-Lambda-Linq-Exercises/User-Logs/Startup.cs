namespace User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var dictionaryOfUsers = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine()
                .Split(new[] { '=', ' ', },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "end")
            {
                input.RemoveAt(0);
                input.RemoveAt(1);
                input.RemoveAt(2);

                if (!dictionaryOfUsers.ContainsKey(input[2]))
                {
                    dictionaryOfUsers.Add(input[2], new Dictionary<string, int>());
                }

                if (!dictionaryOfUsers[input[2]].ContainsKey(input[0]))
                {
                    dictionaryOfUsers[input[2]][input[0]] = 0;
                }

                dictionaryOfUsers[input[2]][input[0]]++;

                input = Console.ReadLine()
                .Split(new[] { '=', ' ', },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            foreach (var item in dictionaryOfUsers)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var ips in item.Value)
                {                    
                    if (ips.Equals(item.Value.Last()))
                    {
                        Console.Write($"{ips.Key} => {ips.Value}.");
                        break;
                    }
                    Console.Write($"{ips.Key} => {ips.Value}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
