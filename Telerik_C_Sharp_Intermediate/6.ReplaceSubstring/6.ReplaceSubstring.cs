using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.ReplaceSubstring
{
    class Program
    {   //Write a program that replaces all occurrences of the sub-string start with the
        //sub-string finish in a text file. Ensure it will work with large files
        static void Main()
        {
            string filePath = @"../../Files/text.txt"; //everything done in the same file
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
            //replace string
            result = result.Replace(targetString, replacementString);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(result.ToString());
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
