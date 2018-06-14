using System;
using System.Numerics;

namespace _6.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] sequence = Console.ReadLine().Split();
            int[] number = new int[n];
            BigInteger odd = 1;
            BigInteger even = 1;
                if (n<=3 || n>51)
            {
                Console.WriteLine("Invalid output!");
            }
            else
            {
                for (int i = 0; i < sequence.Length; i++)
                {
                    number[i] = Convert.ToInt32(sequence[i]);
                }
                for (int j = 0; j < number.Length; j += 2)  //for even members starting from 0 +2... +2
                {
                    even *= number[j];  //the product of all even members
                }
                for (int k = 1; k < number.Length; k += 2)  //for odd members starting from 1 +2 ... +2
                {
                    odd *= number[k];   //the product of all odd members
                }
                if (even == odd)
                {
                    Console.WriteLine("yes {0}", odd);
                }

                else
                {
                    Console.WriteLine("no {0} {1}", even, odd);
                }
            }
        }
    }
}
