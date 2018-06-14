using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8.MixingNumbers
{
    class Program
    {
        /*
            On the first line you will receive an integer 2 <= N <= 1000/
            On the next N lines you will receive N numbers of two-digit non-zero ones on each line
            Your task is to MIX and SUBTRACT each pair of adjacent numbers.

        On the first output line print the mixed numbers            *There should be N - 1 of them
                                                                    *Separate them by spaces
        On the second output line print the subtracted numbers      *There should be N - 1 of them
                                                                    *Separate them by spaces
        Operations:
        MIXING: mixing ab and cd produces b * c     42 mixed with 17 produces 2 * 1 = 2
                                                    17 mixed with 42 produces 7 * 4 = 28
        SUBTRACTING:            42 - 17 = 25
                                39 - 57 = 18 (ignore the sign)
        */
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string mixLine = "";
            string subLine = "";

            int prevNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                mixLine += string.Format("{0} ", ((prevNum % 10) * ((nextNum / 10) % 10)));
                subLine += string.Format("{0} ", Math.Abs(prevNum - nextNum));

                prevNum = nextNum;
            }
            Console.WriteLine(mixLine);
            Console.WriteLine(subLine);
        }
    }
}
