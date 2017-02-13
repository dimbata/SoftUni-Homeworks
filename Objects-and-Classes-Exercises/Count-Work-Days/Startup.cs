namespace Count_Work_Days
{
    using System;
    using System.Globalization;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that reads two dates in format dd-MM-yyyy 
             * and prints the number of working days between these two dates inclusive. 
             * 
             * Non-working days are:
                •	All days that are Saturday or Sunday.
                •	All days that are official holidays in Bulgaria:
                    o	New Year Eve (1 Jan)
                    o	Liberation Day (3 March)
                    o	Worker’s day (1 May)
                    o	Saint George’s Day (6 May)
                    o	Saints Cyril and Methodius Day (24 May)
                    o	Unification Day (6 Sept)
                    o	Independence Day (22 Sept)
                    o	National Awakening Day (1 Nov)
                    o	Christmas (24, 25 and 26 Dec)
            All days not mentioned above are working and should count.
             */

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workDaysCounter = 0;
            DateTime[] holidays = new DateTime[11];
            holidays[0] = new DateTime(2000, 1, 1);
            holidays[1] = new DateTime(2000, 3, 3);
            holidays[2] = new DateTime(2000, 5, 1);
            holidays[3] = new DateTime(2000, 5, 6);
            holidays[4] = new DateTime(2000, 5, 24);
            holidays[5] = new DateTime(2000, 9, 6);
            holidays[6] = new DateTime(2000, 9, 22);
            holidays[7] = new DateTime(2000, 11, 1);
            holidays[8] = new DateTime(2000, 12, 24);
            holidays[9] = new DateTime(2000, 12, 25);
            holidays[10] = new DateTime(2000, 12, 26);

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;

                DateTime temp = new DateTime(2000, i.Month, i.Day);

                if (!holidays.Contains(temp) && day != DayOfWeek.Saturday && day != DayOfWeek.Sunday)
                {
                    workDaysCounter++;
                }
            }

            Console.WriteLine(workDaysCounter);
        }
    }
}
