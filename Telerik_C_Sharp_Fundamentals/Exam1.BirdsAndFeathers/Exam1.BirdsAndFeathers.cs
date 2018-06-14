using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.BirdsAndFeathers
{
    class Program
    {
        /*
        On the first console line you will receive a number 0<=B<=80000, that
        represents the number of birds in the forest. On the second
        console line you will receive a number 0<=F<=2000000000 , that represents
        the total number of bird feathers in the forest.
        
        On the only output line, print the average feathers count 
        per bird with 4 digits precision after the decimal point, 
        modified by the extra given conditions:
         * birds count is an even number - multiply the result by the magic number 123123123123
         * birds count is an odd number - divide the result by the magic number 317.
        */
        static void Main()
        {

            int birds = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());

            double result = 0;
            if (birds !=0)
            {
                double avg = feathers / (double)birds;
                if (birds % 2 == 0)
                {
                    result = avg * 123123123123;
                }
                else
                {
                    result = avg / 317;
                }
            }
            Console.WriteLine("{0:f4}", result);
        }
    }
}
