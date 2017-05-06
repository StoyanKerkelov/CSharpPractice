using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SortingArray
{   /*Write a method that returns the maximal element in a portion of array of integers 
    starting at given index. Using it write another method that sorts an array in 
    ascending / descending order. Write a program that sorts a given array.
    On the first line you will receive the number N - the size of the array
    On the second line you will receive N numbers separated by spaces - the array
    Print the sorted array <->Elements must be separated by spaces
             MaximalElementInPortion();
             SortArrayAscending();
             SortArrayDescending();
    */
    class Program
    {
        private static void PrintSortedArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
        private static void SortAscending(int[] numbers)
        {
            int[] newNums = new int[numbers.Length];
            Array.Copy(numbers, newNums, numbers.Length);
            for (int i = 0; i < newNums.Length - 1; i++)
            {
                for (int j = i + 1; j < newNums.Length; j++)
                {
                    if (newNums[i] > newNums[j])
                    {
                        int temp = newNums[i];
                        newNums[i] = newNums[j];
                        newNums[j] = temp;
                    }
                }
            }
            PrintSortedArray(newNums);
        }

        private static void SortDescending(int[] numbers)
        {
            int[] newNums = new int[numbers.Length];
            Array.Copy(numbers, newNums, numbers.Length);

            for (int i = 0; i < newNums.Length; i++)
            {
                int maxIndex = FindMaxIndex(newNums, i);
                int temp = newNums[i];
                newNums[i] = newNums[maxIndex];
                newNums[maxIndex] = temp;
            }
            PrintSortedArray(newNums);
        }
        static int FindMaxIndex(int[] numbers, int startIndex)
        {
            int currentMaxMember = int.MinValue;
            int currentMaxIndex = startIndex;

            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (currentMaxMember < numbers[i])
                {
                    currentMaxMember = numbers[i];
                    currentMaxIndex = i;
                }
            }
            return currentMaxIndex;
        }
        static void Main(string[] args)
        {
            int[] arrOfDigits =Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

            Console.Write("sorted in Ascending order: ");
            SortAscending(arrOfDigits);
            Console.Write("sorted in Descending order: ");
            SortDescending(arrOfDigits);

        }
    }
}