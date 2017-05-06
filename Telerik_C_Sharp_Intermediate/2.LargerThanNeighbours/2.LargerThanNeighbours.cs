using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LargerThanNeighbours
{
    class Program
    {   /*Write a method that checks if the element at given position in given array of integers
        is larger than its two neighbours (when such exist). 
        
        Write program that reads an array of 
        numbers and prints how many of them are larger than their neighbours.
        On the first line you will receive the number N - the size of the array
        On the second line you will receive N numbers separated by spaces - the array*/

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
            for (int i = 0; i < isLarger.Length; i++)

                if (isLarger[i]== true)
                {
                    count++;
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
