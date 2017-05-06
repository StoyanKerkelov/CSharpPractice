using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ReverseString
{
    class Program
    {//Write a program that reads a string, reverses it and prints the result on the console.
        public static string Reverse(string text)
        {
            if (text == null) return null;
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0}", Reverse(input));
        }
    }
}
