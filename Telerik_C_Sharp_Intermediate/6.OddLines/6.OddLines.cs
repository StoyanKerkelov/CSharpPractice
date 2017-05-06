using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        string fileName = @"../../text.txt";
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int linesCount = 1;
            string currentLine = reader.ReadLine();

            while (currentLine != null)
            {
                if (linesCount % 2 != 0)
                {
                    Console.WriteLine(currentLine);

                }
                linesCount++;
                currentLine = reader.ReadLine();
            }
        }
    }
}
