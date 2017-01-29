using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        /*
         * A program is designed to take some sequences of numbers from the console, to process them as described below and print each obtained sequence.
         * Input
         * •	On the first line of input you are given a count N – the number of sequences.
         * •	On each of the next N lines you will receive some numbers surrounded by whitespaces.
         * Processing Logic
         * You need to check each number, if it’s positive – print it on the console; if it’s negative, add to its value the value of the next number and only print the result if it’s not negative. You only perform the addition once, e.g. if you have the sequence: -3, 1, 3, the algorithm is as follows:
         * •	-3 is negative => add to it the next number (1) => -3 + 1 = -2 still negative => do not print anything (and don’t keep adding numbers, you stop here).
         * •	The next number we consider is 3 which is positive => print it. 
         * If no numbers can be obtained in this manner for the given sequence, print “(empty)”.
         *
         */

        long countSequences = long.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> numbers = new List<double>();

            for (int j = 0; j < input.Length; j++)
            {
                double num = double.Parse(input[j]);
                numbers.Add(num);
            }

            bool found = false;

            for (int k = 0; k < numbers.Count; k++)
            {
                double currentNum = numbers[k];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else
                {
                    if (k < numbers.Count - 1)
                    {
                        currentNum += numbers[k + 1];
                        numbers.Remove(numbers[k + 1]);
                    }


                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.Write("(empty)");
            }
            Console.WriteLine();
        }
    }
}