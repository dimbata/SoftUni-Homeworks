namespace Day_of_Week
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”.
             *  Use an array of strings.
             */

            string[] weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekdays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
