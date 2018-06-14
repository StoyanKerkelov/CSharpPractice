using System;

namespace bitSwap
{


namespace TelerikPractice
    {
        class Program
        {
            static void Main(string[] args)
            {

                int n = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int startP = p;
                int startQ = q;
                int mask = 1;
                int value1;
                int value2;
                while (startP + k - 1 < p)
                {
                    p++;
                    q++;
                    mask = 1;
                }
                Console.WriteLine(n);


            }
        }

    }
}
