namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var items = new Dictionary<string, long>();
            var importantItmes = new Dictionary<string, long>();
            bool earnedLegendary = false;

            items.Add("motes", 0);
            items.Add("fragments", 0);
            items.Add("shards", 0);

            while (true)
            {
                if (earnedLegendary)
                {
                    break;
                }

                var input = Console.ReadLine().ToLower().Split(' ').ToList();

                for (int i = 0; i < input.Count - 1; i += 2)
                {
                    string item = input[i + 1];
                    long quantity = long.Parse(input[i]);

                    if (!items.ContainsKey(item))
                    {
                        items[item] = 0;
                    }

                    items[item] += quantity;


                    if (items["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        items["motes"] -= 250;
                        earnedLegendary = true;
                        break;
                    }
                    else if (items["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        items["fragments"] -= 250;
                        earnedLegendary = true;
                        break;
                    }
                    else if (items["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        items["shards"] -= 250;
                        earnedLegendary = true;
                        break;
                    }
                }
            }

            importantItmes.Add("shards", items["shards"]);
            items.Remove("shards");

            importantItmes.Add("fragments", items["fragments"]);
            items.Remove("fragments");

            importantItmes.Add("motes", items["motes"]);
            items.Remove("motes");

            var orderedImportant = importantItmes.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var orderedMisc = items.OrderBy(x => x.Key);

            foreach (var item in orderedImportant)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in orderedMisc)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
