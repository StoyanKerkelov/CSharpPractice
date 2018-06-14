using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8.MixingNumbersWithArrays
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
            int[] nums = new int[n];
            for (int i = 0; i<nums.Length;i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //////////////////////////////////////////
            int[] mixArr = new int[n - 1];
            int[] subArr = new int[n - 1];
            for (int i=0; i<n-1; i++)
            {
                int firstDig = nums[i] % 10;
                int secondDig = ((nums[i+1]/10) % 10);
                mixArr[i] = firstDig * secondDig;
                subArr[i] = Math.Abs(nums[i] - nums[i+1]);
            }
            Console.WriteLine(string.Join(" ", mixArr));
            Console.WriteLine(string.Join(" ", subArr));
        }
    }
}
