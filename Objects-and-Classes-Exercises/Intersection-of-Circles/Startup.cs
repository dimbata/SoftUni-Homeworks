namespace Intersection_of_Circles
{
    using System;    

    public class Startup
    {
        public static void Main()
        {
            /*
             * Create class Circle with properties Center and Radius. 
             * The center is a point with coordinates X and Y (make a class Point). 
             * Write a method bool Intersect(Circle c1, Circle c2) that tells 
             * whether the two given circles intersect or not. 
             * Write a program that tells if two circles intersect.
             * The input lines will be in format: 
             * {X} {Y} {Radius}. Print as output “Yes” or “No”.
             */

            var firstCircleData = Console.ReadLine().Split(' ');
            var secondCircleData = Console.ReadLine().Split(' ');

            Circle firstCircle = new Circle
            {
                Center = new int[] { int.Parse(firstCircleData[0]),
                    int.Parse(firstCircleData[1]) },
                Radius = double.Parse(firstCircleData[2])                
            };
            Circle secondCircle = new Circle
            {
                Center = new int[] { int.Parse(secondCircleData[0]),
                    int.Parse(secondCircleData[1]) },
                Radius = double.Parse(secondCircleData[2])
            };

            if (Circle.CirclesIntersect(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
