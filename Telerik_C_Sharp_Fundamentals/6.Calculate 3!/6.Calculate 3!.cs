using System;
using System.Numerics;
namespace _6.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            // result = N! / (K! * (N - K)!)
            //1 < K < N < 100
            
            int numN = int.Parse(Console.ReadLine());
            int numK = int.Parse(Console.ReadLine());
            if (numK < 2 || numN < 3 || numN <= numK || numK >= 100 || numN >= 100)
            {
                Console.WriteLine("Invalid input");
            }
            else

            /* The factorial function (symbol: !) means to multiply a series of descending
             * natural numbers. That means N! = N * (N - 1) * (N - 2) * ... * 1 also and
             * K! = K * (K - 1) * (K - 2) * ... * 1.
             * If N > K, K! is Subset of N!, wich means:
             * N! = N * (N - 1) * (N - 2) * ... * (K + 1) * K!
             * To optimize time and performance of this application, we will reduce initial
             * formula from task conditions  RESULT = N! / (K! * (N - K)!)  to next:            
             * 1) = First loop multiplay numbers from N to K + 1;
             * 2) = Second loop calculate Factorial of (N - K)!;
             * RESULT = 1) / 2) . Example: N=7 and K=4, RESULT = 35.   */

            {
                BigInteger factorialNtoK = 1;
                for (int i = numN; i > numK; i--)
                {
                    factorialNtoK *= i;
                }

                BigInteger dividerFactorial = 1;
                for (int j = 2; j <= (numN - numK); j++)
                {
                    dividerFactorial *= j;
                }

                BigInteger resultDivision = factorialNtoK / dividerFactorial;
                Console.WriteLine("{0}", resultDivision);
            }
        }
    }
}

