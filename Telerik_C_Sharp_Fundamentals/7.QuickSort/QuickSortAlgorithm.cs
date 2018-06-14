using System;

namespace _7.QuickSortAlgorithm
{

    class QuickSortAlgorithm
    {
        /* The algorithm starts by choosing a PIVOT value. It proceeds by PARTITIONING of the elements.
         * Elements larger than the pivot are partitioned on the right side of the pivot and element
         * smaller than the pivot are partitioned on the left side of the pivot. It then RECURSIVELY
         * applies the algorithm on the partitions.*/

        static void SwapElements(string[] arr, int first, int second)   //swaping two int elements in array
        {
            string temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        static int Partition(string[] arr, int left, int right, int pivotIndex)
        {
            string pivot = arr[pivotIndex];                 // initialize pivot array
            SwapElements(arr, pivotIndex, right);           // calls SwapElement() method

            int storeIndex = left;
            for (int i = left; i < right; i++)              //storindex = left = current value
            {
                /*String.Compare:strA with strB
                Less than zero -- strA precedes strB in the sort order.
                Zero -- strA occurs in the same position as strB in the sort order.
                Greater than zero -- strA follows strB in the sort order.
                */

                if (string.Compare(arr[i], pivot) <= 0) // If current value > pivot value, then swap(method) in original parsed array[] - element 'storeIndex' with element 'i'
                {
                    SwapElements(arr, storeIndex, i);
                    storeIndex++;
                }
            }
            SwapElements(arr, storeIndex, right);       // Else current value < pivot value, then swap(method) in original parsed array[] - element 'storeIndex' with element 'right'

            return storeIndex;              // returns integer storeIndex
        }

        static void QuickSort(string[] arr, int left, int right)//int left =0; int right =array.Lenght-1;
        {
            if (left >= right)                                  // if left >= right do nothing, they are ordered!
            {
                return;
            }

            /*
            algorithm sudocode:
            quicksort(Array, lower, higher) is
            if lower < higher then
            pivot := partition(Array, lo, hi)
            quicksort(Array, lower, pivot – 1)
            quicksort(Array, pivot + 1, higher)
            */

            // Else right > left, start partitioning
            int pivotIndex = left + (right + 1 - left) / 2;     
            int pivotNewIndex = Partition(arr, left, right, pivotIndex);//initialize 'pivotNewIndex' used in Partition method
            QuickSort(arr, left, pivotNewIndex - 1);                    // recursive function sorting to the left
            QuickSort(arr, pivotNewIndex + 1, right);                   // recursive function sorting to the right
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int index = 0; index < n; index++)
            {
                array[index] = Console.ReadLine();
            }
            //////////////////////////////////////

            QuickSort(array, 0, array.Length - 1); // calls QuickSort() method for original array[] , and elements 0 trough array.Lenght-1
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
            //void Main()>QuickSort()>Partition()>SwapElements()>QuickSort()>...>QuckSort()> Console.WriteLine(RESULT);
        }
    }
}
