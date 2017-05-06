using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {   //Write a program that converts a hexadecimal number N to its decimal representation.

        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine().ToUpper();

            int decimalNumber = 0;
            int number = 0;
            int index = hexadecimalNumber.Length - 1;// to count the powers of 16

            List<char> list = new List<char>();

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                list.Add(hexadecimalNumber[i]);

                if (list[i] == 'A')
                {
                    number = 10;
                }
                else if (list[i] == 'B')
                {
                    number = 11;
                }
                else if (list[i] == 'C')
                {
                    number = 12;
                }
                else if (list[i] == 'D')
                {
                    number = 13;
                }
                else if (list[i] == 'E')
                {
                    number = 14;
                }
                else if (list[i] == 'F')
                {
                    number = 15;
                }
                else
                {
                    number = (int)Char.GetNumericValue(hexadecimalNumber[i]);
                }

                decimalNumber = decimalNumber + (number * (int)Math.Pow(16, index));
                index--;
            }

            Console.WriteLine("{0} -> {1} ", hexadecimalNumber, decimalNumber);
        }
    }
}