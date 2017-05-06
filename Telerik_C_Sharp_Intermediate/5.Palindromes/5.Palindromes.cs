using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Palindromes
//Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe.
//A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward, such as madam or kayak.
    class Program
    {
        static void Main()
        {
            string[] palindromes = { "ABBA", "lamal", "exe", "not", "palindrome", "a" };

            foreach (var word in palindromes)
            {
                Console.WriteLine("{0} is palindrome: {1}", word, IsPalindrome(word));
            }
        }

        private static bool IsPalindrome(string text)//checks Palindrome
    {
            int midPoint = text.Length / 2;
            bool isPalindrome = true;

            for (int counter = 0; counter < midPoint; counter++)//count to half length
            {
                if (text[counter] != text[text.Length - 1 - counter])// A-B-C-B-A
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
