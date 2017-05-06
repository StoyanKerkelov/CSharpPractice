using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace _6.ReplaceWholeWords
{   //Write a program that replaces all occurrences of the word "start" with the word "finish" in a text file. 
    //Ensure it will work with large files
    class Program
    {
        static void Main()
        {
            string filePath = @"../../Files/text.txt";
            string targetString = "start";
            string replacementString = "finish";
            StringBuilder result = new StringBuilder();


            using (StreamReader reader = new StreamReader(filePath))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    result.AppendLine(currentLine);
                }
            }

            string pattern = String.Format(@"\b{0}\b", targetString);
            //replace string
            string replaced = Regex.Replace(result.ToString(), pattern, replacementString, RegexOptions.None);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(replaced);
            }

            using (StreamReader resultReader = new StreamReader(filePath))
            {
                string currentLine;

                while ((currentLine = resultReader.ReadLine()) != null)
                {
                    Console.WriteLine(currentLine);
                }
            }

        }
    }
}
