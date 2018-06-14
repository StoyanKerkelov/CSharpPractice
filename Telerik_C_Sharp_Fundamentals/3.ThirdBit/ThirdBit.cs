using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int showbit = (n & (1 << 3)) >> 3;

            Console.WriteLine(showbit);
        }
    }
}
