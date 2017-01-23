using System;



public class ExactSumOfRealNumbers
{
    public static void Main()
    {
        //Write program to enter n numbers and calculate and print their exact sum (without rounding).

        int n = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int count = 0; count < n; count++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
