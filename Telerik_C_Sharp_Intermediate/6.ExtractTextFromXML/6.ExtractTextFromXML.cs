using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace _6.ExtractTextFromXML
{//Write a program that extracts from given XML file all the text without the tags.
 //exp:
 //<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#
 //</interest><interest>Java</interest></interests></student>
    class Program
    {
        public static void Main()
        {
            string filePath = @"../../Files/text.txt";//only extracs no overwritting
            string pattern = @">(\b[A-Za-z]+\b)</|>(\s*\b[A-Za-z]+\b)</|>(\b[0-9]+\b)</";//regex
            string result = null;
            string currentLine;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    foreach (Match match in Regex.Matches(currentLine, pattern))
                    {
                        result = match.Value.ToString();
                        result = result.Remove(0, 1);//remove fist 2
                        result = result.Remove(result.Length - 2, 2);//remove from 3rd to last to second

                        Console.WriteLine(result != null ? result : "Result is null.");
                    }
                }
            }
        }
    }
}
