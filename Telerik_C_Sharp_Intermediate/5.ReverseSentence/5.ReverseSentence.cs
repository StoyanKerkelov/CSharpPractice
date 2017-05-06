using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ReverseSentence
{
    class Program
    {//Write a program that reverses the words in a given sentence.
        public static string ReverseWord(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] reverseInput = new string[input.Length];

            for (int i = 0; i < reverseInput.Length; i++)
            {
                reverseInput[i] = input[reverseInput.Length - i - 1];
            }

            foreach (string word in reverseInput)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine();
            /*
            foreach (string word in reverseInput)
            {
                Console.Write("{0} ", ReverseWord(word));
            }
            Console.WriteLine();
            */
        }
    }
}
