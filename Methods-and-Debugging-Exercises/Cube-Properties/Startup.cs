namespace Longer_Line
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that can calculate the length of the face diagonals, 
             * space diagonals, volume and surface area of a cube by a given side. 
             * On the first line you will get the side of the cube. 
             * On the second line is given the parameter (face, space, volume or area).
             * Output should be rounded to the second digit after the decimal point.
             */

            double sideLength = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            double result = CalculateCubeProperty(sideLength, property);

            Console.WriteLine($"{result:f2}");
        }

        public static double CalculateCubeProperty(double sideLength, string property)
        { 
            switch (property)
            {
                case "face":
                    return Math.Sqrt(2 * sideLength * sideLength);
                    
                case "space":
                    return Math.Sqrt(3 * sideLength * sideLength);
                    
                case "volume":
                    return sideLength * sideLength * sideLength;
                    
                case "area":
                    return 6 * sideLength * sideLength;
                    
                default:
                    throw new ArgumentException("You have inputted a wrong property !");                    
            }
        }
    }
}