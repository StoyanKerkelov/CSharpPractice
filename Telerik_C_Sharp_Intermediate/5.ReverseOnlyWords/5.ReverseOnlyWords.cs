using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ReverseOnlyWords
{
    class Program
    {   //Write a program that reverses the words in a given sentence WITHOUT the Punctuation marks
        static void Main()
        {
            string text = @"C# is not C++, not PHP and not Delphi!";
            string[] textAsWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<string> words = new Stack<string>();//empty list of words
            Queue<char> punctuation = new Queue<char>();//empty list of signs
            List<bool> wordsWithPunctuation = new List<bool>();//empty list of words with punctuation
            StringBuilder result = new StringBuilder();//result

            foreach (var word in textAsWords)//fill wordsWithPunctuation
            {
                wordsWithPunctuation.Add(ContainsPunctuation(word));
            }

            for (int currentWord = 0; currentWord < wordsWithPunctuation.Count; currentWord++)
            {
                if (!wordsWithPunctuation[currentWord])
                {
                    words.Push(textAsWords[currentWord]);
                }
                else     //fill queue punctuation
                {
                    punctuation.Enqueue(textAsWords[currentWord][textAsWords[currentWord].Length - 1]);
                    textAsWords[currentWord] = textAsWords[currentWord].Remove(textAsWords[currentWord].Length - 1);
                    words.Push(textAsWords[currentWord]);
                }
            }

            for (int currentWord = 0; currentWord < wordsWithPunctuation.Count; currentWord++)
            {
                if (!wordsWithPunctuation[currentWord])
                {
                    result.Append(words.Pop() + " ");
                }
                else
                {
                    result.Append(words.Pop());
                    result.Append(punctuation.Dequeue() + " ");
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }

        private static bool ContainsPunctuation(string text)
        {
            char[] punctSigns = new char[] { ',', '.', '?', '!', ':', ';' };
            bool hasPunct = false;

            for (int currentSign = 0; currentSign < punctSigns.Length; currentSign++)
            {
                if (text.Contains(punctSigns[currentSign].ToString()))
                {
                    hasPunct = true;
                }
            }

            return hasPunct;
        }
    }
}
