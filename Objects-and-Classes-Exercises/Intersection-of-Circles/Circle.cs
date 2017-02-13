namespace Intersection_of_Circles
{
    using System;

    public class Circle
    {
        public int[] Center { get; set; }
        public double Radius { get; set; }

        public static bool CirclesIntersect(Circle first, Circle second)
        {
            double distanceBetweenCentres = Math.Pow(first.Center[0] - second.Center[0], 2) 
                + Math.Pow(first.Center[1] - second.Center[1],2);
            distanceBetweenCentres = Math.Sqrt(distanceBetweenCentres);

            if (distanceBetweenCentres <= first.Radius + second.Radius)
            {
                return true;
            }

            return false;
        }
    }
}
