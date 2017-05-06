using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.DeleteOddLines
{
    class Program
    {
        static void Main()
        {
            string filePath = @"../../Files/text.txt";
            string currentLine;
            int currentLineNumber = 1;
            List<string> linesToKeep = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if (currentLineNumber % 2 == 0)
                    {
                        linesToKeep.Add(currentLine);//keep line
                    }

                    currentLineNumber++;
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in linesToKeep)
                {
                    writer.WriteLine(line);
                }
            }

            using (StreamReader resultReader = new StreamReader(filePath))
            {
                Console.WriteLine(resultReader.ReadToEnd());
            }
        }
    }
}
