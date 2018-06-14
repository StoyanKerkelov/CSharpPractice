using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PermutationsOfSet
{
    class PermutationsOfSet
    {
        //Write a program that reads a number N and generates
        // and prints all the permutations(n!) of the numbers [1 … N].

        static void Permute(int[] arr, bool[] used, int index)
        {
            if (index == arr.Length) //index starts with 0 
            {
                foreach (int element in arr)        //if index == arr.Lenght 
                {                                   //print to Console (counted element+1)
                    Console.Write("{0} ", element + 1);
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (!used[i])                       //if 'used array[i]' false (by defaul thay are all false); 
                {                                   //arr[index]=i
                    arr[index] = i;                 //used[i] = true
                    used[i] = true;                 //recursively Permute() method (arr[i], bool[i(true)], index+1) 
                    Permute(arr, used, index + 1);  //after that used[i] = false
                    used[i] = false;
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            bool[] used = new bool[n];
            Permute(arr, used, 0); //calls Permute(empty int array, used bool array, 0)
        }
    }
}
