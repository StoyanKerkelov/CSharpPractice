using System;
using System.Numerics;

namespace _6.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            //result=((2*n)!)/((n+1)!*n!);
            int num = int.Parse(Console.ReadLine());

            BigInteger firstFac = 1; //(2*n)!
            BigInteger secondFac = 1;//(n+1)!
            BigInteger thirdFac = 1;//n!

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= 2 * num; i++)//(2*n)!
                {
                    firstFac *= i;
                }

                for (int j = 1; j <= num + 1; j++)//(n+1)!
                {
                    secondFac *= j;
                }

                for (int k = 1; k <= num; k++)//n!
                {
                    thirdFac *= k;
                }

                Console.WriteLine("{0}", firstFac / (secondFac * thirdFac));
            }
        }

    }
}
