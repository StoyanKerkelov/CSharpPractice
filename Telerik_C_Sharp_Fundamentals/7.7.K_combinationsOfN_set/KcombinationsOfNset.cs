using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7.K_combinationsOfN_set
{
    class KcombinationsOfNset
    {
        static int elements = 5;
        static void Combinations(int[] array, int index, int currentNumber)//array[k] initial index=0; current number[1..5]
        {
            if (index == array.Length)//index==array.Lenght -->call PrintResult() method
            {
                PrintResult(array);
            }
            else                      //index=!array.Lenght --> for counter:currnet number<=elements ++
            {
                for (int i = currentNumber; i <= elements; i++)
                {
                    array[index] = i;                           //array[index] {from Combinations} = i;
                    Combinations(array, index + 1, i + 1);      //recursively start Combinations() method
                }                                               // for array with (index +1) and elements [i..up to 5]
            }

        }

        static void PrintResult(int[] arr)//--> foreach element in array , print it on console.line
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Combinations(arr, 0, 1);            //calls Combinations() method
        }
    }
}
