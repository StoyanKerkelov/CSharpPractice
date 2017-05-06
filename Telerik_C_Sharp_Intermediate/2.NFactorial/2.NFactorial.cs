using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NFactorial
{
    class Program
    {   //Write a method that multiplies a number represented as an array of digits by a given integer number. 
        //Write a program to calculate N! -- On the first line you will receive the number N
        static int Factorial(int number, int [] array)
        {
            int result = 1;
            int count = 1;
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                result = (i+1) * array[i - 1];
                array[i] = result;
            }
            int sum;
        return sum =array.Sum();
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            Console.WriteLine(Factorial(number, array));

        }
    }
}
