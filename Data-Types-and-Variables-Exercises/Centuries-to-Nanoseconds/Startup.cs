using System;
using System.Numerics;


public class Startup
{
    public static void Main()
    {
        /*
         * Write program to enter an integer number of centuries 
         * and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds. 
         */

        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        long days = (long)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliSeconds = seconds * 1000;
        BigInteger microSeconds = milliSeconds * 1000;
        BigInteger nanoSeconds = microSeconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        
    }
}

