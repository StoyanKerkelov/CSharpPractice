using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.SaveSortedNames
{
    class Program
    {   //Write a program that reads a text file containing a list of strings,
        //sorts them and saves them to another text file.
        static void Main()
        {
            string inputPath = @"../../Files/input.txt";
            string outputPath = @"../../Files/output.txt";//the program makes result.txt file

            List<string> names = new List<string>();

            using (StreamReader reader = new StreamReader(inputPath))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    names.Add(currentLine);
                }
            }

            var sorted = names.OrderBy(n => n);

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (var name in sorted)
                {
                    writer.WriteLine(name);
                }
            }

            using (StreamReader resultReader = new StreamReader(outputPath))
            {
                Console.WriteLine(resultReader.ReadToEnd());
            }
        }
    }
}
