using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //Write a program that converts a binary number N to its decimal representation.
            //1 <= N <= 10^18 = 110111100000101101101011001110100111011001000000000000000000
            string binaryStr = Console.ReadLine();

            byte[] binarics = new byte[binaryStr.Length];// init binarics[] array with 'binaryStr' length
            for (int i = 0; i < binaryStr.Length; i++)
            {                                                               // for every i-th key, parse array member from
                binarics[i] = byte.Parse(Convert.ToString((binaryStr[i]))); // binaryStr
            }
            Array.Reverse(binarics);// reverse the order of the members from 'binarics' array

            long numDecimal = 0;        //the result integer
            long multiplier = 1;        // power of 2
            foreach (var digit in binarics)
            {
                numDecimal += (digit * multiplier);
                multiplier *= 2;
            }

            Console.WriteLine("{0}", numDecimal);
        }
    }
}
