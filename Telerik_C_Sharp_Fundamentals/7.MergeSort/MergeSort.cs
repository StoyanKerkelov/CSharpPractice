using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MergeSort  //Write a program that sorts an array of integers using the Merge sort algorithm.
{
    class MergeSortAlgorithm
    {
        public static int[] MergeSort(int[] array)// Merge sort algorithm
        {
            //Divide the unsorted list into n sublists, each containing 1 element (a list of 1 element is considered sorted).
            //Repeatedly merge sublists to produce new sorted sublists until there is only 1 sublist remaining.
            //This will be the sorted list.

            // If list size is 0 (empty) or 1, consider it sorted and return it
            // (using less than or equal prevents infinite recursion for a zero length array).
            if (array.Length <= 1)
            {
                return array;
            }
            else     // Else list size is > 1, so split the list into two sublists.
            {
                int middleIndex = (array.Length) / 2;
                int[] left = new int[middleIndex];
                int[] right = new int[array.Length - middleIndex];

                Array.Copy(array, left, middleIndex);
                // Array.Copy (sourceArray, Array destinationArray, int length)
                Array.Copy(array, middleIndex, right, 0, right.Length);
                //Copy.Array( sourceArray,int sourceIndex,Array destinationArray,int destinationIndex,int length)

                // Recursively call MergeSort() to further split each sublist until sublist size is 1.
                left = MergeSort(left);
                right = MergeSort(right);

                // Merge the sublists returned from prior calls to MergeSort() and return the resulting merged sublist.
                return Merge(left, right);//calls Merge() method
            }

        }

        public static int[] Merge(int[] left, int[] right)// Merging the sublist into single result array
        {
            // Convert the input arrays to lists, which gives more flexibility 
            // and the option to resize the arrays dynamically.
            List<int> leftList = left.OfType<int>().ToList();
            List<int> rightList = right.OfType<int>().ToList();
            List<int> resultList = new List<int>();

            // While the sublist are not empty merge them repeatedly to produce new sublists 
            // until there is only 1 sublist remaining. This will be the sorted list.
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare the 2 lists, append the smaller element to the result list
                    // and remove it from the original list.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }

                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Convert the resulting list back to a static array
            int[] result = resultList.ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            /////////////////////////////////////////////////////

            array = MergeSort(array); //calling MERGESORT method
            
            for (int j = 0; j < array.Length; j++) // Printing the sorted list
            {
                Console.WriteLine("{0}", array[j]); //("element[{0}] = {1}", j, array[j]);
            }
            Console.WriteLine();
        }
    }//void Main()>MergeSort>Merge - return result[]>void Main () consoleWriteLine(result[])
}
