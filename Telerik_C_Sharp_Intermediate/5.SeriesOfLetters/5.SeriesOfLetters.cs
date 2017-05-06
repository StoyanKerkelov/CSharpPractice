using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SeriesOfLetters
{   //Write a program that reads a string from the console and replaces all series of
    //consecutive identical letters with a single one.
    class Program
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            List<char> output = new List<char>();

            for (int currentChar = 0; currentChar < input.Length - 1; currentChar++)
            {
                if (input[currentChar] != input[currentChar + 1])
                {
                    output.Add(input[currentChar]);
                }
            }

            if (input[input.Length - 1] != output[output.Count - 1])
            {
                output.Add(input[input.Length - 1]);
            }

            Console.WriteLine("Original Text: \n{0}\n", input);
            Console.WriteLine("All series of letters replaced with single occurance: \n");

            foreach (var character in output)
            {
                Console.Write(character);
            }

            Console.WriteLine("\n");
        }
    }
}
