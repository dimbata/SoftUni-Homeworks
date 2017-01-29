namespace Longer_Line
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            /*
             * A master number is an integer that holds the following properties:
             * •Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
             * •Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
             * •Holds at least one even digit, e.g. 232, 707, 6886, 87578.
             * Write a program to print all master numbers in the range [1…n].
             */

            long endNumber = long.Parse(Console.ReadLine());

            for (long i = 1; i <= endNumber; i++)
            {
                if (IsMasterNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static bool IsMasterNumber(long number)
        {
            if (IsSymmetric(number) 
                && DigitsDivisableBySeven(number) 
                && HasAtLeastOneEvenDigit(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsSymmetric(long number)
        {
            char[] allDigits = number.ToString().ToCharArray();
            int reverseCounter = allDigits.Length - 1;

            for (int i = 0; i < allDigits.Length; i++)
            {
                if (allDigits[i] != allDigits[reverseCounter])
                {
                    return false;
                }

                reverseCounter--;
            }

            return true;
        }

        public static bool DigitsDivisableBySeven(long number)
        {
            int sum = 0;
            foreach (var digit in number.ToString())
            {
                sum += digit - '0';
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool HasAtLeastOneEvenDigit(long number)
        {
            foreach (var digit in number.ToString())
            {
                if ((digit - '0') % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
