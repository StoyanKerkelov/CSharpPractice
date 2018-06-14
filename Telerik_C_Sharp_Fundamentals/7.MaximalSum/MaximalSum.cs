using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //////////////////////////////////
            int max_so_far = 0, max_ending_here = 0;

            for (int i = 0; i < n; i++)
            {
                max_ending_here = max_ending_here + array[i];
                if (max_ending_here < 0)
                    { max_ending_here = 0; }

                if (max_so_far < max_ending_here)
                    { max_so_far = max_ending_here; }
            }
            Console.WriteLine(max_so_far);
        }
    }
}
