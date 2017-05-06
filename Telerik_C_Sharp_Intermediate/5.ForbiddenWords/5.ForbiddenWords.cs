using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ForbiddenWords
{
    class Program
    {   //We are given a string containing a list of forbidden words and a text containing some of these words.
        //Write a program that replaces the forbidden words with asterisks.
        static void Main()
        {
            //Console.WriteLine("Submit the text you want to censure");string text = Console.ReadLine();
            string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
                        implemented as a dynamic language in CLR.";

            Console.WriteLine("write the words that you want to censure with SPACE between them");
            string[] forbiddenWords = Console.ReadLine().Split().ToArray();
            //string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            foreach (var word in forbiddenWords)
            {//Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string
                text = text.Replace(word, new String('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
