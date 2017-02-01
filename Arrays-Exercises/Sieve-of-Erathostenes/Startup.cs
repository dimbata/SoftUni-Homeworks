namespace Sieve_of_Eratosthenes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            /*
             * Write a program to find all prime numbers in range [1…n]. 
             * Implement the algorithm called “Sieve of Eratosthenes”
             */

            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];
            int[] numbersArray = new int[n + 1];
            string output = string.Empty;

            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
                numbersArray[i] = i;
            }

            Console.WriteLine(SieveOfErat(numbersArray, primes, output));

        }

        public static string SieveOfErat(int[] arrayOfNums, bool[] arrayOfBools, string output)
        {
            arrayOfBools[0] = false;
            arrayOfBools[1] = false;

            for (int i = 2; i < arrayOfBools.Length; i++)
            {
                if (arrayOfBools[i])
                {
                    output += $"{arrayOfNums[i]} ";

                    for (int j = 2 * i; j < arrayOfBools.Length; j += i)
                    {
                        if (arrayOfNums[j] % i == 0 && arrayOfBools[j])
                        {
                            arrayOfBools[j] = false;
                        }
                    }
                }
            }

            return output;
        }
    }
}
