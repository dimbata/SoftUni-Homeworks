namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are given a sequence of people and for every person what cards he draws from the deck.
             *  The input will be separate lines in the format:
                {personName}: {PT, PT, PT,… PT}
                Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and
                T (S, H, D, C) is the type. The input ends when a "JOKER" is drawn. 
                The name can contain any ASCII symbol except ':'. 
                The input will always be valid and in the format described, there is no need to check it.
                A single person cannot have more than one card with the same power and type, 
                if he draws such a card he discards it. 
                The people are playing with multiple decks. 
                Each card has a value that is calculated by the power multiplied by the type. 
                Powers 2 to 10 have the same value and J to A are 11 to 14. 
                Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
                Finally print out the total value each player has in his hand in the format:
                {personName}: {value}
             */

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                .Split(new[] { ' ', ':', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "JOKER")
            {
                if (!dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = input.Skip(1).Distinct().ToList();
                }
                else
                {
                    dict[input[0]].AddRange(input.Skip(1).Distinct().ToList());
                }
                
                input = Console.ReadLine()
                .Split(new[] { ' ', ':', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();
            }

            foreach (var item in dict)
            {
                long sum = 0;

                foreach (var value in item.Value.Distinct())
                {
                    sum += CardCounter(value);
                }

                Console.WriteLine($"{item.Key}: {sum}");
                sum = 0;
            }
        }

        public static long CardCounter(string input)
        {
            string card = input.ToUpper();
            long sum = 0;

            if (card[0] - '0' > 1 && card[0] - '0' < 10)
            {
                sum = card[0] - '0';
            }

            switch (card[0])
            {
                case '1':
                    sum = 10;
                    break;
                case 'J':
                    sum = 11;
                    break;
                case 'Q':
                    sum = 12;
                    break;
                case 'K':
                    sum = 13;
                    break;
                case 'A':
                    sum = 14;
                    break;
                default:
                    break;
            }

            switch (card[card.Length - 1])
            {
                case 'S':
                    sum *= 4;
                    break;
                case 'H':
                    sum *= 3;
                    break;
                case 'D':
                    sum *= 2;
                    break;
                case 'C':
                    sum *= 1;
                    break;
                default:
                    break;
            }

            return sum;
        }
    }
}
