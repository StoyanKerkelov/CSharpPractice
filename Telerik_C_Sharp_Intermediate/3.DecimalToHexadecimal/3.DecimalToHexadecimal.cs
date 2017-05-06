using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class Program
    {   //Write a program that converts a decimal number N to its hexadecimal representation.
        //On the only line you will receive a decimal number - 1 <= N <= 10^18
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //String can only be appended. Unlike a string, a StringBuilder can be changed. With it, 
            //an algorithm that modifies characters in a loop runs fast. Thisway Many string copies are avoided.

            StringBuilder list = new StringBuilder();

            while (number != 0)// loops trough number 
            {
                if (number % 16 > 9)// every time the quotient of devision by 16 is 
                                    // larger than 9
                {
                    switch (number % 16)
                    {
                        case 10:
                            list.Append("A");
                            break;
                        case 11:
                            list.Append("B");
                            break;
                        case 12:
                            list.Append("C");
                            break;
                        case 13:
                            list.Append("D");
                            break;
                        case 14:
                            list.Append("E");
                            break;
                        case 15:
                            list.Append("F");
                            break;
                    }
                }
                else   // if not bigger then 9, append it to the list
                {
                    list.Append((number % 16).ToString()); 
                }
                number /= 16; // for every loop divide by 16
            }

            // print the list backwards
            for (int i = list.Length - 1; i > -1; i--)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
