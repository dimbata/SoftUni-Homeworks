namespace Center_Point
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. 
             * Create a method that prints the point that is closest to the center of the coordinate system (0, 0) 
             * in the format (X, Y). If the points are on a same distance from the center, print only the first one.
             */

            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());
            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(FindPointClosestToCenter(xOne, yOne, xTwo, yTwo));
        }

        public static string FindPointClosestToCenter(double xOne, double yOne, double xTwo, double yTwo)
        {
            double firstPointDistance = (xOne * xOne) + (yOne * yOne);
            double secondPointDistance = (xTwo * xTwo) + (yTwo * yTwo);

            if (firstPointDistance < secondPointDistance)
            {
                return $"({xOne}, {yOne})";
            }
            else
            {
                return $"({xTwo}, {yTwo})";
            }
        }
    }
}
