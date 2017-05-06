using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


namespace _6.ConcatenateTextFiles
{//Write a program that concatenates two text files into another text file.
    class Program
    {
        static void Main()
        {
            try
            {
                string fileOne = @"../../Files/TextFile1.txt";
                string fileTwo = @"../../Files/TextFile2.txt";

                StreamReader readerOne = new StreamReader(fileOne);
                StreamReader readerTwo = new StreamReader(fileTwo);
                StreamWriter writer = new StreamWriter("../../Files/result.txt");//the program creates this third file

                try    //checks for exeptions
                {
                    string currentLine;

                    while ((currentLine = readerOne.ReadLine()) != null)
                    {
                        writer.WriteLine(currentLine);
                    }

                    while ((currentLine = readerTwo.ReadLine()) != null)
                    {
                        writer.WriteLine(currentLine);
                    }
                }
                finally
                {
                    readerOne.Close();
                    readerTwo.Close();
                    writer.Close();
                }

                using (StreamReader reader = new StreamReader("../../Files/result.txt"))
                {
                    string resultLine = reader.ReadLine();

                    while (resultLine != null)
                    {
                        Console.WriteLine(resultLine);// write line
                        resultLine = reader.ReadLine();//this line is red form reader
                    }
                }
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
