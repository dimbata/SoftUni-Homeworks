namespace Print_Triangle
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        public static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }

            for (int i = number -1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
