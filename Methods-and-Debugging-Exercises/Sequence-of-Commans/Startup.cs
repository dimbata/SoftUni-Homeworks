using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        /*
         * You are given a program that reads a n numbers and a sequence of commands to be executed over these numbers.
         * Input
         * •	The first line holds an integer n – the count of numbers.
         * •	The second line holds n numbers – integers separated by space.
         * •	Each of the next few lines hold commands in format: “[action] [i-th element] [value]”.
         * •	The commands sequence end with a command “stop”.
         * Commands
         * Commands are given in format “[action] [i-th element] [value]”. Elements are indexed from 1 to n.
         * The action can be “multiply”, “add”, “subtract”, “rshift” or “lshift”.
         * •	The actions “multiply”, “add” and “subtract” have parameters. The first parameter is the index of the element that needs to be changed (in range [1...n]). The second parameter is the value with which we manipulate the element.
         * •	The command “lshift” moves the first element last. E.g. “lshift” over {1, 2, 3} will produce {2, 3, 1}.
         * •	The command “rshift” moves the last element first. E.g. “rshift” over {1, 2, 3} will produce {3, 1, 2}.
         * Output
         * Print the values of the n elements after the execution of each command (except the last “stop” command).
         */

        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] line = command.Trim().Split(' ');
            long[] args = new long[2];

            if (line[0].Equals("add") ||
                line[0].Equals("subtract") ||
                line[0].Equals("multiply"))
            {                
                args[0] = long.Parse(line[1]) - 1;
                args[1] = long.Parse(line[2]);
            }

            PerformAction(array, line[0], args);

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, long[] args)
    {
        long[] array = arr;
        long pos = args[0];
        long value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
        PrintArray(array);
    }

    private static void ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = temp;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = temp;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
