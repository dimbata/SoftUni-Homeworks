using System;

public class Substring_broken
{
    public static void Main()
    {
        /*
         * You are given a text and a number count. 
         * Your program should search through the text for the letter 'p' (ASCII code 112) 
         * and print 'p' along with count letters to its right.
         * For example, we are given the text "phahah put" and count = 3. 
         * We find a match of 'p' in the first letter so we print it and the 3 letters to its right. 
         * The result is "phah". We continue and find another match of 'p', but there aren't 3 letters to its right,
         * so we print only "put". 
         * Each match should be printed on a separate line. 
         * If there are no matches of 'p' in the text, we print "no".
         */

        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int outerBound = (i + jump) - (text.Length - 1);

                if (outerBound > 0)
                {
                    jump -= outerBound;
                }

                string matchedString = text.Substring(i, jump + 1);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
