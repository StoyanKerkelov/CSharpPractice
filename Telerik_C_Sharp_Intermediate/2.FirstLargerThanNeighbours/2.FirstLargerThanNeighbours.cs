using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FirstLargerThanNeighbours
{
    class Program
    {   //Write a method that returns the index of the first element in array that 
        //is larger than its neighbours, or -1, if there is no such element.

        public static int IsLargerThanNeighbors(int[] nums, int countNum)
        {
            bool[] isLarger = new bool[countNum];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    isLarger[i] = false;//nums[i + 1] < nums[i];
                }
                else if (i > 0 && i < nums.Length - 1)
                {
                    isLarger[i] = nums[i - 1] < nums[i] && nums[i + 1] < nums[i];
                }
                else
                {
                    isLarger[i] = false;//nums[i - 1] < nums[i];
                }
            }
            int count = 0;
            int j = 0;
            while (isLarger[j] == false)
            {
                count++;
                j++;
            }
            return count;
        }

        static void Main()
        {
            int countNum = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(IsLargerThanNeighbors(nums, countNum));

            /*for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbors(nums, countNum, i));
            }*/
        }
    }
}

