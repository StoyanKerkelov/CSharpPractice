using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.Lecture
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;// the console needs to know the proper Encoding of the file

            var stream = new StreamReader(@"..\..\text.txt", Encoding.UTF8);// file + encoding type
            var line = stream.ReadLine();
            var i = 1;

            while (line != null)// printing file contents one row at a time
            {
                Console.WriteLine($"Line {i}: {line}");
                i++;
                line = stream.ReadLine();
            }
        }
    }
}
