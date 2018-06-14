using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam7.HiddenMessage
{
    class Program
    {
        /*
        Decipher hidden message. -->The output should consist of a single line containing the full hidden message.
        Rules:
        1.The first number -100<=I<=100 is the index of the symbol we should start decoding (starting from 0)
        2.The second number -100<=S<=100 (excluding 0) is the number of symbols he needs to skip to reach the next symbol from the hidden message.. 
            If the starting index is larger than the length of the line, this means that the line should be skipped.
        3.Message always ends with 'end' instead of the starting index I (see sample tests).
        4.If S<0 your program should look for the next symbol to the left of the starting index (go backwards).
        5.If I<0 your program should take the symbol counting from the end of the line as starting index
            example 1: for I = -1 -- line of code: "some random text that makes no sencE"
            example 2: for I = -6 -- line of code: "some random text that makes no_sence" (the space)

                input	                |result	     |explanation
                ________________________|____________|____________________
                4                       |codi        |add carbon additive
                4                       |            |start from c (4th symbol counting from 0),
                add CarbOn adDitIve     |            |then take every 4th -> o, d and i
                end                     |            |
        */
        static void Main()
        {
            string hiddenMessage = ""; //initial hiddenMessage is empty
            while (true)               //continue looping until break
            {
                string indStr = Console.ReadLine(); //read the index of the symbol 'I' we should start decoding
                if (indStr =="end") { break; }      //case 'end' break while loop

                int ind = int.Parse(indStr);        //case number, parse 'indStr' to integer
                int step = int.Parse(Console.ReadLine());//the number of symbols 'S' we need to skip to reach the next symbol from the message (excl. 0)
                string line = Console.ReadLine();   //line of undeciphered text

                if (ind < 0)                        // case I<0 take the symbol counting from the 
                {                                   // end of the line as starting index
                    ind += line.Length;             // it's the same as {ind = line.Length;}
                }
                for (; ind < line.Length && ind >= 0; ind += step)// take every S step up to index of symbol I<line.Length
                {
                    hiddenMessage += line[ind];
                }
            }
            Console.WriteLine(hiddenMessage);
        }
    }
}
