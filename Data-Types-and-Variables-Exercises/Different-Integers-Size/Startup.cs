using System;
using System.Numerics;


public class Startup
{
    public static void Main()
    {
        /*
         * Given an input integer, you must determine which primitive data types 
         * are capable of properly storing that input.
         */

        BigInteger input = BigInteger.Parse(Console.ReadLine());

        string output = $"{input} can fit in:";
        if (input <= sbyte.MaxValue && input >= sbyte.MinValue)
        {
            output += "\n* sbyte";
        }
        if (input <= byte.MaxValue && input >= byte.MinValue)
        {
            output += "\n* byte";
        }
        if (input <= short.MaxValue && input >= short.MinValue)
        {
            output += "\n* short";
        }
        if (input <= ushort.MaxValue && input >= ushort.MinValue)
        {
            output += "\n* ushort";
        }
        if (input <= int.MaxValue && input >= int.MinValue)
        {
            output += "\n* int";
        }
        if (input <= uint.MaxValue && input >= uint.MinValue)
        {
            output += "\n* uint";
        }
        if (input <= long.MaxValue && input >= long.MinValue)
        {
            output += "\n* long";
        }

        if (input > long.MaxValue || input < long.MinValue)
        {
            Console.WriteLine("{0} can't fit in any type",input);
        }
        else
        {
            Console.WriteLine(output);
        }


    }
}
