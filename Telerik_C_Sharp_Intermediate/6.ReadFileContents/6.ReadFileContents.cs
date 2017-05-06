using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.ReadFileContents
{   //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini
    //reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(...).
    //Be sure to catch all possible exceptions and print user-friendly error messages.

    class ReadFileContents
    {
        static void Main()
        {
            string path = @"..\..\text.txt";

            try
            {
                var fileContent = File.ReadAllText(path);
                Console.WriteLine(fileContent);
            }
            catch (ArgumentException)//INVALID PATH
            {
                Console.WriteLine("Invalid or empty path \"{0}\" !", path);
            }
            catch (PathTooLongException)//PATH TOO LONG
            {
                Console.WriteLine("File path \"{0}\" is too long!", path);
            }
            catch (DirectoryNotFoundException)//DIRECTORY NOT FOUND
            {
                Console.WriteLine("The path \"{0}\" specified is invalid", path);
            }
            catch (UnauthorizedAccessException)//READ ONLY, NO ACCESS
            {
                Console.WriteLine("File is read-only or you don't have access or path speciefies directory or operation is not supported by platform!");
            }
            catch (FileNotFoundException)//FILE NOT FOUND
            {
                Console.WriteLine("The file specified by the path \"{0}\" can not be found!", path);
            }
            catch (NotSupportedException)//NOT SUPPORTED FORMAT
            {
                Console.WriteLine("The path \"{0}\" is in invalid format!", path);
            }
        }
    }
}
