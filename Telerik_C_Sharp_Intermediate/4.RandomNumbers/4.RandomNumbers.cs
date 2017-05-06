using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RandomNumbers
{
    class Program
    {
        static void Main()
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,2} random value generated: {1}",
                    i + 1, randomGenerator.Next(100, 201));
            }
        }

    }
}
