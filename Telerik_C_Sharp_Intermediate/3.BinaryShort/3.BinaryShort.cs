using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BinaryFloatingPoint
{
    class BinaryShort
    {   //Write a program that shows the binary representation of given
        // 16-bit signed integer number N (the C# type short).
        static void Main(string[] args)
        {
            Console.Write("Enter 16-bit signed number: ");
            int number = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            if (number >= 0)
            {
                while (number > 0)
                {
                    result.Add(number % 2);
                    number /= 2;
                }
                while (result.Count < 16)
                {
                    result.Add(0);
                }
                result.Reverse();
                foreach (int element in result)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
            else
            {
                number = Math.Abs(number) - 1;
                while (number > 0)
                {
                    result.Add(number % 2);
                    number /= 2;
                }
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == 0)
                    {
                        result[i] = 1;
                    }
                    else
                    {
                        result[i] = 0;
                    }
                }
                while (result.Count < 16)
                {
                    result.Add(1);
                }
                result.Reverse();
                foreach (int element in result)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }
    }
}

