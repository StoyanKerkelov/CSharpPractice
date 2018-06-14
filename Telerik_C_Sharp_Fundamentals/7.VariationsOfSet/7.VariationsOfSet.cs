using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.VariationsOfSet
{
    class Program
    {
        //Write a program that reads two numbers N and K and generates 
        //all the variations of K elements from the set [1..N].
        //V=n!/(n-k)!=(n-1).(n-2)....(m-k+1)

        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            Console.WriteLine("Permutatons:\n");
            int[] array = new int[N]; //creating array that lists all integers from 1 to N
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Variations(array, new int[K], 0);

        }

        private static void Variations(int[] numbers, int[] array, int index)//array[N], array [K], 0
        {
            if (index == array.Length)              //if array[k]lenght=index 
            {                                               //at beginning array[k].Length=k+1
                Console.WriteLine(string.Join(", ", array));    // print array[k]
                return;
            }
            for (int i = 0; i < numbers.Length; i++)// for  0=counter<N; counter ++
            {
                array[index] = numbers[i];          //array[k](with index=0)=array[N](with index=counter)
                Variations(numbers, array, index + 1);// do the same for the next index until array[k]lenght=index 
            }
        }
    }
}

