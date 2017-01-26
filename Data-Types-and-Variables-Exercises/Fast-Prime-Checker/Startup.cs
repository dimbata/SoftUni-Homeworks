using System;

public class Startup
{
    public static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        for (long numberCounter = 2; numberCounter <= input; numberCounter++)
        {
            bool isPrime = true;                      
            for (long divider = 2; divider <= Math.Sqrt(numberCounter); divider++)
            {
                if (numberCounter % divider == 0 && numberCounter > 2)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{numberCounter} -> {isPrime}");
        }

    }
}

