using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.LineNumbers
{   //Write a program that reads a text file and inserts line numbers in front 
    //of each of its lines. The result should be written to another text file.
    class Program
    {
        static void Main()
        {
            string sourcePath = @"../../Files/text.txt";
            string resultPath = @"../../Files/result.txt";

            using (StreamReader reader = new StreamReader(sourcePath))//write tne new result file
            {
                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    string currentLine;
                    int lineNumber = 1;//counting starts from 1

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        writer.WriteLine("{0,2}. {1}", lineNumber, currentLine);//write padding 2 to the left linecount, currentLine
                        lineNumber++;//countig lines ++
                    }
                }
            }

            using (StreamReader resultReader = new StreamReader(resultPath))//print the new result file
            {
                string resultLine;

                while ((resultLine = resultReader.ReadLine()) != null)
                {
                    Console.WriteLine(resultLine);
                }
            }
        }
    }
}

