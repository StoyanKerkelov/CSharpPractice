using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            ////////////////////////////////////////
            int x = int.Parse(Console.ReadLine());
            int min = 0;
            int max = n;
            int mid;
            while (true)    //in loop until completion
            {
                mid = (min + max) / 2;
                if (x > array[mid])
                {
                    min = mid + 1;  //min----------------mid--------x--------max//
                }
                else
                {
                    max = mid;      //min---------x------mid----------------max//
                }
                if (min == max || min == max - 1) //checks for no acurrence.
                {
                    if (array[min] == x)
                    {
                        Console.WriteLine(min);
                        return;
                    }
                    else if (array[max] == x)
                    {
                        Console.WriteLine(max);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }
            }
        }
    }
}
