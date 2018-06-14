using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5.BobbyAvokadoto
{
    class Program
    {
        /*
        Bobby combs his hair.(the 1s in 32-bit unsigned N represent his hairs and
        0s represent his bald spots and the 1s in int 0<C<90000 represent the 
        comb's teeth). Bobby can use a comb only if his head and the 
        comb don't have any overlapping set of bits. The best comb for
        Bobby is the comb with most teeth (bits set to 1) that he can use.

            check:
               10001 hair
               01110 comb
               -----
            ok 11111 } | OR
            ok 00000 } & AND
                
        17 is 10001 - Bobi's head
        14 is  1110 - comb - Bobi can use 14, because no bits overlap.
        2  is    10 - comb - Bobi can use 2, because no bits overlap.
        19 is 10011 - comb - Bobi can't use 19, because there are overlapping bits.

        Write a program that prints the best comb for Bobby by given N and C.
        */
        static void Main()
        {
            uint head = uint.Parse(Console.ReadLine());         //INPUT N 32-bit unsigned hair
            uint combCount = uint.Parse(Console.ReadLine());    //INPUT count of combs 0<C<90000

            uint bestComb = 0;
            int bestCount = 0;
            for (int i = 0; i < combCount; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());     //INPUT separately every comb option

                if ((head & comb) == 0)// check if comb is valid; read in commentary
                {   
                    //count teeth of every option                   //check: 1 & 1 = 1; 0 & 1 = 0;
                    int currentCount = 0;                           //up to the 32th bit take every 
                    for (int j = 0; j < 32 && (comb >> j) > 0; j++) //bit from the current comb
                    {                                               //and sum it to 'currentCount'
                        currentCount += (int)((comb >> j) & 1);     //if bit=1 sum+=1; if bit=0 sum+=0
                    }
                    //check if best
                    if (currentCount > bestCount)
                    {                    //the best comb is the largest number,that passed the check
                        bestCount = currentCount;
                        bestComb = comb;
                    }
                }
            }
            Console.WriteLine(bestComb);
        }
    }
}
