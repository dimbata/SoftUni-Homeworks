namespace Calculate_Triangle_Area
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            /*
             * Create a method that calculates and returns the area of a triangle by given base and height
             */

            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(baseSide,height));
        }

        public static double TriangleArea(double baseSide, double height)
        {
            return (baseSide * height) / 2;
        }
    }
}
