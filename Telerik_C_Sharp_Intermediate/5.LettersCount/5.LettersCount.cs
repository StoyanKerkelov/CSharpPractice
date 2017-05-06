using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LettersCount
{   //Write a program that reads a string from the console and prints all different letters 
    //in the string along with information how many times each letter is found.
    class Program
    {
        static void Main()
        {
            string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int currentCharacter = 0; currentCharacter < text.Length; currentCharacter++)
            {
                if (Char.IsLetter(text[currentCharacter]))//if it is a letter
                {
                    if (letters.ContainsKey(text[currentCharacter]))// if the letter is in the dictionary
                    {
                        letters[text[currentCharacter]]++;//add +1 to the listed letter
                    }
                    else
                    {
                        letters.Add(text[currentCharacter], 1);// if it isn't - add the letter to the dictionay
                    }
                }
            }

            var sortedLetters = letters.OrderByDescending(l => l.Value);

            foreach (var letter in sortedLetters)
            {
                Console.WriteLine("Letter \"{0}\" is found {1} time(s)", letter.Key, letters[letter.Key]);
            }
        }
    }
}
