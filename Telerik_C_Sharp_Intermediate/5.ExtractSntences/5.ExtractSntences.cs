using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ExtractSntences
{
    class Program
    {//Write a program that extracts from a given text all sentences containing given word
     //On the first line you will receive a string - the word
     //On the second line you will receive a string - the text
        static void Main()
        {   //example
            //string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //string stringToFind = "in";

            string text = Console.ReadLine();
            string stringToFind = Console.ReadLine();
            //Console.WriteLine("Original text: \n{0}\n", text);

            string[] sentences = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();
            foreach (var sentence in sentences)
            {
                if (ContainsString(sentence, stringToFind))
                {
                    output.Append(sentence + ".");
                }
            }

            Console.WriteLine("Sentences that contain word \"{0}\" :\n{1}\n", stringToFind, output.ToString());
        }

        private static bool ContainsString(string text, string stringToFind)
        {
            int position = -1;
            bool isFound = false;

            while (text.IndexOf(stringToFind, position + 1) != -1)
            {
                if (!Char.IsLetter(text[text.IndexOf(stringToFind, position + 1) - 1]) && !Char.IsLetter(text[text.IndexOf(stringToFind, position + 1) + stringToFind.Length]))
                {
                    isFound = true;
                    break;
                }

                position++;
            }

            return isFound;
        }
    }
}
