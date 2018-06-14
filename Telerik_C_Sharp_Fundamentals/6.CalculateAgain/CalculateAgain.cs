using System;
using System.Numerics;

namespace _6.CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            //1 < K < N < 100  N! / K!
            if (N <= 1 || N > 100 || N <= K || K < 1 || K >= 100)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                /* If looked deeply in factorial function formula, we will understand
                 * why is not necessarily calculate N! and K! separately.
                 * N!=N*(N-1)*(N-2)*...*1 and K!=K*(K-1)*(K-2)*...1;
                 * If N>K K! is Subset of N!, that's mean:
                 * N!= N*(N-1)*(N-2)*...*K*(K-1)*(K-2)*...*1;
                 * Division of N! by K! means:
                 * RESULT = N*(N-1)*(N-2)*...(K+1);
                 * Example: What is 7! / 4! = 7 × 6 × 5 = 210;*/

                BigInteger resultDivision = 1;
                for (int i = N; i > K; i--)
                {
                    resultDivision *= i;
                }
                Console.WriteLine(resultDivision);
            }

        }


    }
}
