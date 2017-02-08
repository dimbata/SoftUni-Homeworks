namespace Srubsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Startup
    {
        public static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, BigInteger>>();

            var input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();
                string singer = input
                    .Split('@')
                    .ToArray()[0];

                if (singer[singer.Length - 1] != ' ' 
                    || input.Split(' ').ToArray().Length < 4)
                {
                    continue;
                }

                var venueArr = input.Split('@')
                    .ToList()[1]
                    .Split(' ')
                    .Reverse()
                    .Skip(2)
                    .Reverse();

                string venue = string.Join(" ", venueArr);
                BigInteger ticketPrice = BigInteger.Parse(input.Split(' ').Reverse().ToArray()[1]);
                BigInteger ticketCount = BigInteger.Parse(input.Split(' ').Reverse().ToArray()[0]);

                if (!venues.ContainsKey(venue))
                {
                    venues[venue] = new Dictionary<string, BigInteger>();
                }

                if (!venues[venue].ContainsKey(singer))
                {
                    venues[venue][singer] = 0;
                }

                venues[venue][singer] += ticketCount * ticketPrice;
            }

            foreach (var item in venues)
            {
                var ordered = item.Value.OrderByDescending(x => x.Value);
                Console.WriteLine($"{item.Key}");
                foreach (var singer in ordered)
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
