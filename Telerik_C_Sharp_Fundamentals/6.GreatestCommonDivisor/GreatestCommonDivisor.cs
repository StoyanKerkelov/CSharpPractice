using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {

            string[] nums = Console.ReadLine().Split(' ');
            int a = Math.Abs(int.Parse(nums[0]));
            int b = Math.Abs(int.Parse(nums[1]));

                int remain = 1;
                while (remain != 0) 
                {
                    remain = a % b;
                    a = b;
                    b = remain;
                }
                Console.WriteLine(Math.Abs(a));
            
        }
    }
}
