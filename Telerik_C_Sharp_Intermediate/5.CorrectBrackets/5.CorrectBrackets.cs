using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CorrectBrackets
{//Write a program to check if in a given expression the ( and ) brackets are put correctly.
    class Program
    {
        public static string Check(string text)
        {
            if (text == null) return null;

            string result ="Correct";
            int openingBrackets = 0, closingBrackets = 0;
            for (int i =0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    openingBrackets++;
                }

                if (text[i] == ')')
                {
                    closingBrackets++;
                }
            }

            if (openingBrackets == closingBrackets) { return result; }

            else { result = "Incorrect"; return result; }
        }

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0}", Check(input));
        }
    }
}
