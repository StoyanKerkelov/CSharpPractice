using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetLargestNumber
{       // Write a method GetMax() with two parameters that returns the larger of two integers.
        // Write a program that reads 3 integers 
        // from the console and prints the largest of them using the method GetMax().
        //On the first line you will receive 3 integers separated by spaces
    class Program
    {
        static int GetMax(int integer1, int integer2)
        {
            int result = integer1;
            if (result < integer2)
            {
                result = integer2;
            }
            return result;
        }
        static void Main()
        {
            int[] integerArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            /*string[] input = Console.ReadLine().Split(' ');
            int[] integerArray = new int[input.Length];
            for (int i =0; i<input.Length; i++)
            {
                integerArray[i] = int.Parse(input[i]);
            }
            */
            int[] result = new int[integerArray.Length-1];
            int output;
            //////////////////////////////
            for (int i=0; i< integerArray.Length-1; i++)
            {
                result[i]= GetMax(integerArray[0 + i], integerArray[1 + i]);
            }
            Console.WriteLine(result.Max());
        }
    }
}
