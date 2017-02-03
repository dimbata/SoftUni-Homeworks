namespace Greater_of_Two_Values
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are given two values of the same type as input. 
             * The values can be of type int, char of string. 
             * Create a method GetMax() that returns the greater of the two values
             */

            string type = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
            }
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        public static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
