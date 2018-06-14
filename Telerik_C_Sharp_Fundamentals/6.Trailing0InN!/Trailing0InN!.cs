using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Trailing0InN_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int d;
            for (int i = 5; i <= number; i += 5)
            {
                d = i;
                while (d % 5 == 0)//checks for d=5^(somepower)
                {
                    d /= 5;
                    zeroCount++;// adds also the power 
                }
            }
            Console.WriteLine(zeroCount);

        }
    }
}
