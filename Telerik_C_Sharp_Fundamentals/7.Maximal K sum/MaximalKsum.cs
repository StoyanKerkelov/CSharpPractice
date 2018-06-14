using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find the maximal sum of K elements in the array.

namespace _7.Maximal_K_sum
{
    class MaximalKsum
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //////////////////////////////////

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int number = array[i];
                        array[i] = array[j];
                        array[j] = number;
                    }
                }
            }

            for (int i = 1; i <= k; i++)
            {
                sum = sum + array[n - i];
            }

            Console.WriteLine(sum);

        }
    }
}
