using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToBinary
{
    class DecimalToBinary
    {   //Write a program that converts a decimal number N to its binary representation
        //On the only line you will receive a decimal number - 1 <= N <= 10^18
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());

            long rest;
            string binary = string.Empty;

            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;// first the newly made result then the old string
            }

            Console.WriteLine(binary);
        }
    }
}
