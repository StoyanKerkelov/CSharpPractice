using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            int[] arr2 = new int[N];

            if (N > 20 || N <= 0)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < N; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }


                bool equal = arr1.SequenceEqual(arr2);
                if (equal)
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }

            }
        }
    }
}
