using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _6.Prefix_test
{
    class Program
    {   //Write a program that deletes from a text file all words that start
        //with the prefix test. Words contain only the symbols 0…9, a…z, A…Z, _.
        static void Main()
        {
            string filePath = @"../../Files/input.txt";
            string pattern = @"\b\w*test[A-Za-z0-9_]*";
            string replacement = " ";
            string currentLine;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(Regex.Replace(currentLine, pattern, replacement));
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}
