using System;



public class CircleArea12DigitsPrecision
{
    public static void Main()
    {
        //Write program to enter a radius r (real number) and print the area of the circle 
        //with exactly 12 digits after the decimal point.


        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f12}", radius * radius * Math.PI);
    }
}

