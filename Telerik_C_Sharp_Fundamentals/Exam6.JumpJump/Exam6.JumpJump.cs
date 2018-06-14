using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam6.JumpJump
{
    class Program
    {
        /*
        The INPUT will consist of a string - the instructions how to jump - never more than 100 symbols.
        You will never jump in loops. The string consists only of digits and party symbols '^'
        RULES:
        *You will start jumping from the first symbol of the instructions(at position 0).
        *If you jump on an even digit, do the following:
            >Take it's value P as a number('2' is 2, '4' is 4 and so on)
            >JUMP P positions FORWARD
        *If you jump on an odd digit
            >Take it's value P as a number('1' is 1, '3' is 3 and so on)
            >JUMP P positions BACKWARDS
        *If you jump on a '0'(zero), you pass out because you've drank too much alchohol
            >PRINT "Too drunk to go on after {POSITION}!", where POSITION is the index at which you jumped on the '0'
            >STOP JUMPING
        *If you jump on '^'(party symbol), you did some good jumping
            >PRINT "Jump, Jump, DJ Tomekk kommt at {POSITION}!", where POSITION is the index at which you jumped on the party symbol '^'
            >STOP JUMPING
        *If you jump outside the boundaries of the instructions, you fall off the dancefloor
            >PRINT "Fell off the dancefloor at {POSITION}!", where POSITION is the index at which you jumped you're out of the instructions
            >STOP JUMPING

        OUTPUT the result of the instructions.
        */
        static void Main()
        {
            var instructions = Console.ReadLine();      //INPUT string
            var i = 0;                                  // symbol(char) in string

            while (0 <= i && i < instructions.Length)   //WHILE i is positve or zero and i<instructions.Length
            {                                           //for every case return and loop next instance
                if (instructions[i] == '0')             //case i=0
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    return;
                }
                if (instructions[i] == '^')             //case i=^
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    return;
                }
                // converting char to integer = 'char' symbol - '0' symbol
                var code = instructions[i] - '0';       //take the number value out from char value
                if (code % 2 == 0)                      //case i even digit
                {
                    i += code;
                }
                else                                    // case i odd digit
                {
                    i -= code;
                }
            }

            if (i < 0 || instructions.Length <= i)      //case i out of instructions or negative number
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", i);
            }
        }
    }
}
