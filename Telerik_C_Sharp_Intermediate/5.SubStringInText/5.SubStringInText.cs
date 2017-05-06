using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SubStringInText
{
    class Program
    {   //Write a program that finds how many times a sub-string is contained in a given text
        //(perform case insensitive search).
        static void Main()
        {   //example:
            //string testText = @"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";
            //string testSubstring = @"in";

            Console.WriteLine("Enter text: ");
            string testText = Console.ReadLine();
            Console.WriteLine("Enter sub-string to find in text:");
            string testSubstring = Console.ReadLine();

            Console.WriteLine("{0} is found {1} time(s) in the text:\n{2}", testSubstring, CountOccurances(testText, testSubstring), testText);
        }

        private static int CountOccurances(string text, string subString)
        {
            int occurances = 0, position = -1;

            while (text.IndexOf(subString, position + 1) != -1)//Reports the zero-based index of the first occurrence of a specified 
                                                               //Unicode character or string within this instance
                                                               //returns -1 if the character or string is not found in this instance
            {
                position = text.IndexOf(subString, position + 1); //start from the last found occurance
                occurances++;// counts only if IndexOf returns != -1
            }
            return occurances;
        }





    }
}
