using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSortAlgorithm
{
    class SelectionSortAlgorithm
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
            for (int j = 0; j < n - 1; j++)         /* find the min element in the unsorted a[j .. n-1] */
            {
                int iMin = j;                       /* assume the min is the first element */
                for (int k = j + 1; k < n; k++)     /* test against elements after j to find the smallest */
                {
                    if (array[k] < array[iMin])     /* if this element is less, then it is the new minimum */
                    {
                        iMin = k;                   /* found new minimum; remember its index */
                    }
                }

                if (iMin != j)                      //swap(a[j], a[iMin]);
                {
                    int temp = array[iMin];
                    array[iMin] = array[j];
                    array[j] = temp;
                }
            }
            //////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
