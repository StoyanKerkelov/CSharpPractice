using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CombinationsOfSet
{
    class Program
    {
        //Write a program that reads two numbers N and K and generates 
        //all the combinations of K distinct elements from the set [1..N].
        //C=n!/(K!*(n-k)!)

        static int[] result;
        static int K;
        static int N;
        static void Main()
        {
            // input
            N = int.Parse(Console.ReadLine());  //number of elements for combinations
            K = int.Parse(Console.ReadLine());  //lenght of combination

            result = new int[K];
            Combinations(0, 1);         //Combinations method
        }
        static void Combinations(int index, int startValue)
        {
            if (index == K) // print the result when we have exactly K elements
            {
                for (int i = 0; i < K; i++)
                    Console.Write("{0,3}", result[i]);
                Console.WriteLine();
                return;
            }
            for (int i = startValue; i <= N; i++) // contiuously change elements' indexes in result array
            {
                result[index] = i; //result[k] (with index [0 up to K])= i[1 up to N]
                Combinations(index + 1, i + 1);//combinations(0...+1;1...+1)
            }
        }
    }
}
