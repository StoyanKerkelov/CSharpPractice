using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FormatNumbers
{
    class Program
    {
        //Write a program that reads a number and prints it as a DECIMAL number, HEXADECIMAL number,
        //PERCENTAGE and in SCIENTIFIC notation. Format the output aligned right in 15 symbols.

        static void Main()
        {
            Console.WriteLine("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number.ToString("D"));
            Console.WriteLine("{0,15}", number.ToString("X"));
            Console.WriteLine("{0,15}", number.ToString("P"));
            Console.WriteLine("{0,15}", number.ToString("E"));
        }
    }
}
