namespace Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /* Andrey is the guy who gives us food and drinks at the game bar.
             * He likes to play billiard.
             * Since you are nice guy you want to help him play more of his favorite game. 
             * You decide to create a program which will help him to take orders faster 
             * and generate billing information. 
               First you will receive an integer - the amount of entities with prices(separated by "-").
               Then you will receive a list of client.For every consumer you will receive what to buy and how much.
               When you receive a command: "end of clients" you should display information about every client described below.
               After that say how much total money were spent while Andrey was playing billiard.
               Constraints
                - If an entity is added more than once you should override the previous price.
                -	If buyer tries to buy an entity that is not existing - you should ignore that line.
                -	Buyers should be ordered by name ascending.
                -	All floating point digits must be rounded to 2 digits after decimal separator.
                -	In the end of every buyer his bill should be summed.
                -	Quantity is an integer. Price – floating point.
            */

            Dictionary<string, double> menu = new Dictionary<string, double>();
            int numberOfItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfItems; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                if (!menu.ContainsKey(input[0]))
                {
                    menu.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    menu[input[0]] = double.Parse(input[1]);
                }

            }
            List<Customer> allCustomers = new List<Customer>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end of clients")
                {
                    break;
                }
                
                string[] clientInfo = info.Split('-', ',');
                string customerName = clientInfo[0];
                string product = clientInfo[1];
                int quantity = int.Parse(clientInfo[2]);
               
                if (!menu.ContainsKey(product)) { continue; }

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, int>();
                client.Name = clientInfo[0];
                client.ShopList.Add(product, quantity);

                if (allCustomers.Any(c => c.Name == customerName))
                {
                    Customer existingCustomer = allCustomers.First(c => c.Name == customerName);
                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }
            /// Това го правим само за да направим bill-a:
            foreach (var customer in allCustomers)
            {
                foreach (var item in customer.ShopList)
                {

                    foreach (var product in menu)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }
            var ordered = allCustomers
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }
            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
        }
    }
}
