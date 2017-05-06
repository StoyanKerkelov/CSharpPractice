using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.CompareTextFiles
{   //Write a program that compares two text files line by line and prints the number
    //of lines that are the same and the number of lines that are different. Assume
    //the files have equal number of lines.
    class Program
    {
        static void Main()
        {
            string fileOnePath = @"../../Files/text1.txt";
            string fileTwoPath = @"../../Files/text2.txt";

            StreamReader fileOneReader = new StreamReader(fileOnePath);
            StreamReader fileTwoReader = new StreamReader(fileTwoPath);

            try//only prints the result it doesn't make a file
            {
                string fileOneCurrentLine = fileOneReader.ReadLine();//read one line
                string fileTwoCurrentLine = fileTwoReader.ReadLine();

                while (fileOneCurrentLine != null)// to the end of first file lines
                {
                    if (fileOneCurrentLine == fileTwoCurrentLine)
                    {
                        Console.WriteLine(fileOneCurrentLine + " = " + fileTwoCurrentLine);
                    }
                    else
                    {
                        Console.WriteLine(fileOneCurrentLine + " =/= " + fileTwoCurrentLine);
                    }

                    fileOneCurrentLine = fileOneReader.ReadLine();// new line
                    fileTwoCurrentLine = fileTwoReader.ReadLine();// new line
                }
            }
            finally
            {
                fileOneReader.Close();
                fileTwoReader.Close();
            }
        }
    }
}