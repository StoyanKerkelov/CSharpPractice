using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            if (N<1 || N>1024)
            {
                Console.WriteLine("invalid output");
            }
            else
            {
                int[] array = new int[N];

                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                ////////////////////////////////////////////////////

                int bestSequence = 1;
                int currentSequence = 1;
                //int bestNumber = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == (array[i + 1]) - 1)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }
                    if (currentSequence >= bestSequence)
                    {
                        bestSequence = currentSequence;

                    }
                }

                Console.WriteLine(bestSequence);

            }

        }
    }
}
