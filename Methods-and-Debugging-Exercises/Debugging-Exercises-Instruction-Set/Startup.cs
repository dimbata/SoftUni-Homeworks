using System;
using System.Numerics;

class InstructionSet_broken
{
    static void Main()
    {

        /*
         * Write an instruction interpreter that executes an arbitrary number of instructions. 
         * The program should parse the instructions, execute them and print the result. 
         * The following instruction set should be supported:
            •	INC <operand1> – increments the operand by 1
            •	DEC <operand1> – decrements the operand by 1
            •	ADD <operand1> <operand2> – performs addition on the two operands
            •	MLA <operand1> <operand2> – performs multiplication on the two operands
            •	END – end of input
         */

        string opCode = Console.ReadLine();

        while (opCode != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            BigInteger result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);

            opCode = Console.ReadLine();
        }
    }
}