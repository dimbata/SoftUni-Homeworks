namespace Users_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, SortedDictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                string user = input[1];
                string ip = input[0];
                long duration = long.Parse(input[2]);

                if (!users.ContainsKey(user))
                {
                    users[user] = new SortedDictionary<string, long>();
                }

                if (!users[user].ContainsKey(ip))
                {
                    users[user][ip] = 0;
                }

                users[user][ip] += duration;
            }

            foreach (var user in users)
            {
                Console.Write($"{user.Key}: ");
                Console.Write($"{user.Value.Values.Sum()} [" + string.Join(", ", user.Value.Keys) + "]");
                Console.WriteLine();
            }
        }
    }
}
