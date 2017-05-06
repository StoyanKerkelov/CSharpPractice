using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.LectureWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"..\..\text.txt";
            var encoding = Encoding.UTF8;
            var appendToFile = true;// we want to save everithing we write

            using (var writer = new StreamWriter(fileName, appendToFile, encoding))
            {
                writer.AutoFlush = true;
                writer.WriteLine("THIS is written by C#");
            }
        }
    }
}
