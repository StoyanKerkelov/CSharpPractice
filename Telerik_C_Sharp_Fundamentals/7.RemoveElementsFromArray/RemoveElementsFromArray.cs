using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.RemoveElementsFromarrayay
{
    /*Write a program that reads an array of integers and removes from it a
     *minimal number of elements in such a way that the remaining array is
     *sorted in increasing order. Print the minimal number of elements
     *that need to be removed in order for the array to become sorted.*/
    class RemoveElementsFromarrayay
    {
        static int[] output;
        static int maxLength;
        static void GenerateSubset(int[] array, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)                  //if index is the same as the counter elementInSubset
            {
                CheckSubsets(subset, elementsInSubset);     // calls Checksubsets() method
                return;
            }

            for (int i = current; i < array.Length; i++)    //repeat the same method (recursive) but with +1 starting conditions
            {
                subset[index] = array[i];
                GenerateSubset(array, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            for (int i = 1; i < elementsInSubset; i++)
            {
                if (subset[i] < subset[i - 1])              //If members in subset[] declineing break method
                {
                    return;
                }
                if (i > maxLength)                          //if couter>MaxLenght (initial maxLength=0) 
                {                                           
                    maxLength = i;                          //maxLength=counter
                    for (int j = 0; j <= maxLength; j++)    //for every loop -> output[loopcount]=subset[loopcount]
                    {
                        output[j] = subset[j];

                    }
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter array members count and then enter them: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];                       //creates new int array[n]
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                array[index] = int.Parse(Console.ReadLine());
            }
            ////////////////////////////////////////
            output = new int[n];                            //creates new int subset[n]
            int[] subset = new int[n];
            for (int elementsInSubset = 1; elementsInSubset <= n; elementsInSubset++)
            {
                GenerateSubset(array, subset, 0, 0, elementsInSubset); //for every element of subset[j] 
            }                                                          //call GenerateSubset() method

            for (int i = 0; i <= maxLength; i++)                       //print  the result from
            {                                                          //CheckSubsets() method
                Console.WriteLine("{0} ", output[i]);
            }
            //void Main()>GenerateSubset()>CheckSubsets()-->Console.WriteLine("{0} ", output[i]);
            Console.WriteLine("Minimal is {0}", (n-(maxLength+2)));
        }
    }
}
