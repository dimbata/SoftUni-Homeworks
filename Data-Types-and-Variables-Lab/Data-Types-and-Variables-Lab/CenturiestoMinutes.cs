using System;



public class CenturiesToMinutes
{
    public static void Main()
    {
        //Write program to enter an integer number of centuries
        //and convert it to years, days, hours and minutes.
        //Assume that a year has 365.2422 days at average (the Tropical year).


        int input = int.Parse(Console.ReadLine());
        int years = input * 100;
        int days = (int)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;
        Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

    }
}

