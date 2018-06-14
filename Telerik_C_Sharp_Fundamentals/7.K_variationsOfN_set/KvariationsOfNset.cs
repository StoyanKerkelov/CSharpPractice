using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.K_variationsOfN_set
{

    //Write a program that generates all the variations of K elements from the set [1..N]
    class KvariationsOfNset
    {
        static void Variations(int[] array, int index, int elements)
        {
            if (index == array.Length)
            {
                PrintResult(array);   //index == array.Length --> call print Result
            }
            else
            {
                for (int i = 1; i <= elements; i++)         //if index=!array.Lenght
                {                                           //array[index] = i
                    array[index] = i;                       //recursively start Variations() method for 
                    Variations(array, index + 1, elements); //array with (index +1) and elements (n) 
                }
            }
        }

        static void PrintResult(int[] array)//--> foreach element in array , print it on console.line
        {
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            Variations(array, 0, n); //calls Variations method strting with 0
        }
    }
}
