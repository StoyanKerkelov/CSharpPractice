using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WordDictionary
{
    class Program
    {//Write a program that enters a word and translates it by using the dictionary.
        private static Dictionary<string, string> InitializeDictionary()
        {
            Dictionary<string, string> sampleDictionary = new Dictionary<string, string>();//multidim Dictionary
            sampleDictionary.Add(".NET", "platform for applications from Microsoft");
            sampleDictionary.Add("CLR", "managed execution environment for .NET");
            sampleDictionary.Add("namespace", "hierarchical organization of classes");
            return sampleDictionary;
        }
        static void Main()
        {
            Dictionary<string, string> myDictionary = InitializeDictionary();

            Console.WriteLine("Enter word: ");
            string lookupWord = Console.ReadLine();

            bool isInDictionary = myDictionary.ContainsKey(lookupWord);//check
            while (!isInDictionary)//if not repeat
            {
                Console.WriteLine("\nDictionary contains: ");

                foreach (var word in myDictionary)
                {
                    Console.WriteLine(word.Key);
                }
                Console.WriteLine("\nEnter new word: ");
                lookupWord = Console.ReadLine();
                isInDictionary = myDictionary.ContainsKey(lookupWord);
            }

            Console.WriteLine("{0} means: {1}", lookupWord, myDictionary[lookupWord]);
        }
    }
}
