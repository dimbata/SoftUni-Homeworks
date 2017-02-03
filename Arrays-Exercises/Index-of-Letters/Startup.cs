namespace Index_of_Letters
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Write a program that creates an array containing all letters from the alphabet (a-z). 
             * Read a lowercase word from the console and print the index of each of its letters in the letters array.
             */

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {alphabet.IndexOf(word[i])}");
            }
        }
    }
}
