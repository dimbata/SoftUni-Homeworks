using System;



public class TriplesOfLatinLetters
{
    public static void Main()
    {
        /*
          Write a program to read an integer n and print all triples
          of the first n small Latin letters, ordered alphabetically.
         */

        int n = int.Parse(Console.ReadLine());

        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int third = 0; third < n; third++)
                {
                    Console.WriteLine($"{(char)(first + 'a')}-{(char)(second + 'a')}-{(char)(third + 'a')}");
                }
            }
        }


    }
}

