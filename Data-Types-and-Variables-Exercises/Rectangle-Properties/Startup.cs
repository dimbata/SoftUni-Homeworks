using System;


public class Startup
{
    public static void Main()
    {
        /*
         * Create a program to calculate rectangle’s perimeter, 
         * area and diagonal by given its width and height
         */

        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        double diagonal = Math.Sqrt((height * height) + (width * width));

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }   
}

