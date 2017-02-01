namespace Blank_Receipt
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create a method that prints a blank cash receipt. 
             * The method should invoke three other methods: one for printingthe header, 
             * one for the body and one for the footer of the receipt.
             */

            PrintReceipt();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 20));
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to__________");
            Console.WriteLine("Received by_________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("\u00A9 SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
