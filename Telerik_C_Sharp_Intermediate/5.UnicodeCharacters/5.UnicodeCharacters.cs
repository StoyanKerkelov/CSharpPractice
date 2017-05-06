using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.UnicodeCharacters
{
    class Program
    {
        //Write a program that converts a string to a sequence of C# Unicode character literals.
        //example: Hi! | \u0048\u0069\u0021

        class UnicodeCharacters
        {
            static void Main()
            {
                //string text = @"Microsoft!";
                string text = Console.ReadLine();
                int temp = 0;

                for (int counter = 0; counter < text.Length; counter++)
                {
                    temp = (int)text[counter];
                    Console.Write("\\u{0}", temp.ToString("X4"));
                }
            }
        }
    }
}
