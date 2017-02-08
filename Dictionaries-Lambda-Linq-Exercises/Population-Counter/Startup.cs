namespace Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var populations = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine().Split('|').ToList();

            while (input[0] != "report")
            {
                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);

                if (!populations.ContainsKey(country))
                {
                    populations[country] = new Dictionary<string, long>();
                }

                if (!populations[country].ContainsKey(city))
                {
                    populations[country][city] = 0;
                }

                populations[country][city] += population;

                input = Console.ReadLine().Split('|').ToList();
            }

            foreach (var state in populations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
