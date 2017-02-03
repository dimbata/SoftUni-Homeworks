namespace Draw_a_Filled_Square
{
    using System;
    using System.Text;
    public class Startup
    {
        public static void Main()
        {
            /*
             * Draw at the console a filled square of size n.
             */

            int n = int.Parse(Console.ReadLine());

            PrintSquare(n);
        }

        public static void PrintSquareHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        public static void PrintSquareContents(int n)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append('-');

            for (int i = 0; i < n - 1; i++)
            {
                builder.Append("\\/");
            }

            builder.Append('-');

            Console.WriteLine(builder);
        }

        public static void PrintSquare(int n)
        {
            PrintSquareHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintSquareContents(n);
            }
            PrintSquareHeaderRow(n);
        }
    }
}
