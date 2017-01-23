using System;



public class Elevator
{
    public static void Main()
    {
        /*Calculate how many courses will be needed to 
        elevate n persons by using an elevator of capacity of p
        persons. The input holds two lines: the number of people n 
        and the capacity p of the elevator.
         */

        int n = int.Parse(Console.ReadLine());
        // We use double for the capacity in order to avoid the integer division
        double p = double.Parse(Console.ReadLine());
        int coursesNeeded = (int)Math.Ceiling(n / p);
        Console.WriteLine(coursesNeeded);

    }
}

