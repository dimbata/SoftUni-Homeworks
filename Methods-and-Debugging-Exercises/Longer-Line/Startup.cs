namespace Longer_Line
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are given the coordinates of four points in the 2D plane. 
             * The first and the second pair of points form two different lines. 
             * Print the longer line in format "(X1, Y1)(X2, Y2)" 
             * starting with the point that is closer to the center of the coordinate system (0, 0)
             *  (You can reuse the method that you wrote for the previous problem). 
             *  If the lines are of equal length, print only the first one.
             */

            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());
            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());
            double xThree = double.Parse(Console.ReadLine());
            double yThree = double.Parse(Console.ReadLine());
            double xFour = double.Parse(Console.ReadLine());
            double yFour = double.Parse(Console.ReadLine());

            double[] longestLine = FindTheLongerOfTwoLines(xOne,yOne,xTwo,yTwo,xThree,yThree,xFour,yFour);
            string result = FindLineClosestToCenter(longestLine);

            Console.WriteLine(result);
        }

        public static double[] FindTheLongerOfTwoLines(params double[] arrayOfPoints)
        {           
            double firstLineLength = Math.Sqrt(Math.Abs(arrayOfPoints[0] - arrayOfPoints[2]) + Math.Abs(arrayOfPoints[1] - arrayOfPoints[3]));
            double secondLineLength = Math.Sqrt(Math.Abs(arrayOfPoints[4] - arrayOfPoints[6]) + Math.Abs(arrayOfPoints[5] - arrayOfPoints[7]));

            if (firstLineLength >= secondLineLength)
            {
                return new double[] { arrayOfPoints[0], arrayOfPoints[1], arrayOfPoints[2], arrayOfPoints[3] };
            }
            else
            {
                return new double[] { arrayOfPoints[4], arrayOfPoints[5], arrayOfPoints[6], arrayOfPoints[7] };
            }
        }

        public static string FindLineClosestToCenter(params double[] arrayOfPoints)
        {
            double firstPointDistance = Math.Abs(arrayOfPoints[0]) + Math.Abs(arrayOfPoints[1]);
            double secondPointDistance = Math.Abs(arrayOfPoints[2]) + Math.Abs(arrayOfPoints[3]);

            if (firstPointDistance <= secondPointDistance)
            {
                return $"({arrayOfPoints[0]}, {arrayOfPoints[1]})({arrayOfPoints[2]}, {arrayOfPoints[3]})";
            }
            else
            {
                return $"({arrayOfPoints[2]}, {arrayOfPoints[3]})({arrayOfPoints[0]}, {arrayOfPoints[1]})";
            }
        }
    }
}
