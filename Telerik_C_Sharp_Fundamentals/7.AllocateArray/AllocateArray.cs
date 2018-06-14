using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];

            if (N>20||N<=0)
            {
                Console.WriteLine("invalid input");
            }
            else
            {

                for (int i=0; i<N ;i++)
                {
                    numbers[i] = i*5;
                    Console.WriteLine(numbers[i]);
                }


            }

        }
    }
}
