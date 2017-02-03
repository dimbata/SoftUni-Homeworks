
namespace Price_Change_Alert
{
    using System;

    class Startup
    {
        static void Main()
        {
            /*
             * You are assigned to rework a given piece of code which is working 
             * without bugs but is not properly formatted.
             * The given program tracks stock prices and gives updates about the significance in each price change. 
             * Based on the significance, there are four kind of changes:
             *  no change at all (price is equal to the previous), 
             *  minor (difference is below the significance threshold), 
             *  price up and price down.  
             *  
             *  •	On the first line you are given N - the number of prices
             *  •	On the second line you are given the significance threshold
             *  •	On the next N lines, you are given prices
             */


            int numOfPrices = int.Parse(Console.ReadLine());

            double threshold = double.Parse(Console.ReadLine());

            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPrices - 1; i++)
            {
                double c = double.Parse(Console.ReadLine());
                double div = PercentChange(last, c);
                bool isSignificantDifference = CheckForDifference(div, threshold);

                string message = CheckPriceSituation(c, last, div, isSignificantDifference);
                Console.WriteLine(message);

                last = c;
            }
        }

        private static string CheckPriceSituation(double current, double last, double difference, bool significantDifference)
        {
            string output = "";
            if (difference == 0)
            {
                output = $"NO CHANGE: {current}";
            }
            else if (!significantDifference)
            {
                output = $"MINOR CHANGE: {last} to {current} ({difference * 100:F2}%)";
            }
            else if (significantDifference && (difference > 0))
            {
                output = $"PRICE UP: {last} to {current} ({difference * 100:F2}%)";
            }
            else if (significantDifference && (difference < 0))
            {
                output = $"PRICE DOWN: {last} to {current} ({difference * 100:F2}%)";
            }

            return output;
        }
        private static bool CheckForDifference(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double PercentChange(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}


