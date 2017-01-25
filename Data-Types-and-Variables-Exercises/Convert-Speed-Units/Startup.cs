using System;



public class Startup
{
    public static void Main()
    {
        /*
         * Create a program to ask the user for a distance (in meters) 
         * and the time taken (as three numbers: hours, minutes, seconds), 
         * and print the speed, in meters per second, kilometers per hour and miles per hour.
         * Assume 1 mile = 1609 meters.
         */

        double distanceInMeters = double.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        double minutes = double.Parse(Console.ReadLine());
        double seconds = double.Parse(Console.ReadLine());

        double metersPerSecond = (distanceInMeters / ((hours * 3600) + (minutes * 60) + seconds));
        double KPH = ((distanceInMeters / 1000) / (hours + (minutes / 60) + (seconds / 3600)));
        double MPH = ((distanceInMeters / 1609) / (hours + (minutes / 60) + (seconds / 3600)));


        Console.WriteLine(metersPerSecond);
        Console.WriteLine(KPH);
        Console.WriteLine(MPH);

    }
}

