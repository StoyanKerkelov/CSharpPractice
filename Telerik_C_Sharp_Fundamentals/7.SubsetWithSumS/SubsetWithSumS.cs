using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SubsetWithSumS
{
    class SubsetWithSumS
    {
        /*
        We are given an array of integers and a number S. Write a program to find if 
        there exists a subset of the elements of the array that has a sum S.
        */
        static int wantedSum;
        static bool solution = false;

        static void GenerateSubset(int[] array, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)              //if index is the same as the counter elementInSubset
            {
                CheckSubsets(subset, elementsInSubset); // calls Checksubsets() method
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
            int sum = 0;
            for (int i = 0; i < elementsInSubset; i++)
            {
                sum += subset[i];           //collect all elements from the subset
            }
            if (sum == wantedSum)                           //if this |^| sum is equal to the parsed WantedSum
            {                                               //Console.Write (count-wise) element from subset[]
                for (int i = 0; i < elementsInSubset; i++)  //new line after the end of the loop
                {                                           //silution = true
                    Console.Write("{0} ", subset[i]);   
                }
                Console.WriteLine();    
                solution = true;        
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int index = 0; index < n; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            //////////////////////////////////////
            Console.Write("Enter the sum of subset of elements: ");
            wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[n];
            for (int elementsInSubset = 1; elementsInSubset <= n; elementsInSubset++)
            {
                GenerateSubset(array, subset, 0, 0, elementsInSubset);// calls GenerateSubset() method
            }

            if (solution)
            {
                Console.WriteLine("yes, there is such a subset");
            }
            else
            {
                Console.WriteLine("No subset with sum {0} doesn't exists .", wantedSum);
            }
            //main()>GenerateSubset()>CheckSubsets()>CheckSubset()...CheckSubset()>Console.WriteLine(yes/no)>END
        }
    }
}
