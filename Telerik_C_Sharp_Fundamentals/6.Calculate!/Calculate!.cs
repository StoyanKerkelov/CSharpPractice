using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum;
            // S = 1 + 1!/x + 2!/x^2 + … + N!/x^N.
            */

            int numN = int.Parse(Console.ReadLine());       //n
            float numX = float.Parse(Console.ReadLine());   //x
            if (numN < 1 || Math.Abs(numN) > 10 || Math.Abs(numX) < 0.5 || Math.Abs(numX) > 100)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                // The formula is Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N

                double factorialN = 1;
                double numXPowerN = 1;
                double sumOfSequence = 1;
                for (int i = 1; i <= numN; i++)
                {
                    factorialN *= i;
                    numXPowerN *= numX;
                    sumOfSequence += (factorialN / numXPowerN);
                }
                Console.WriteLine("{0:F5}", sumOfSequence);
            }

        }
    }
}
