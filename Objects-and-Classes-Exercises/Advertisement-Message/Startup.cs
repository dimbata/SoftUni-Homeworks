namespace Advertisement_Message
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that generate random fake advertisement message to extol some product. 
             * The messages must consist of 4 parts: laudatory phrase + event + author + city. 
             * Use the following predefined parts:
                •	Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}
                •	Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}
                •	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
                •	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
                The format of the output message is: {phrase} {event} {author} – {city}.
                As an input you take the number of messages to be generated. 
                Print each random message at a separate line.    
             */

            int n = int.Parse(Console.ReadLine());

            string[] phrases = new[] {"Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = new[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] author = new[] { "Diana", "Petya",
                "Stella", "Elena",
                "Katya", "Iva",
                "Annie", "Eva" };
            string[] cities = new[] { "Burgas", "Sofia",
                "Plovdiv", "Varna", "Ruse" };

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[rand.Next(0,phrases.Length)]} {events[rand.Next(0,events.Length)]} {author[rand.Next(0,author.Length)]} - {cities[rand.Next(0,cities.Length)]}");
            }
        }
    }
}
