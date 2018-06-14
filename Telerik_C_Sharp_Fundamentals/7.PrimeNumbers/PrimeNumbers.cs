using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PrimeNumbers
{
    class PrimeNumbers
    {
        /*
        *Write a program that finds all prime numbers in the range [1 ... N]. [2 <= N <= 10 000 000]
        *Use the SIEVE OF ERATOSTHENES algorithm. The program should print 
        * the biggest prime number which is <= N.
        */
        static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            bool[] boolArr = new bool[n];       //by default they're all false
            List<int> result = new List<int>();

            for (int i = 1; i < n; i++)
            {
                boolArr[i] = true;              //set all numbers to true
            }
            ////////////////////////////////////////
            for (int j = 2; j < n; j++)                 //weed out the non primes by finding mutiples 
            {
                if (boolArr[j])                         //if 'j' is member of boolArr
                {
                    for (long k = 2; (k * j) < n; k++) 
                    {
                        boolArr[k * j] = false; // take out every element that is the sum [k * j] for k=2,3,5,7.. and j<n
                    }
                }
            }

         
            for (int i = 0; i < boolArr.Length; i++)// boolArr takes only true values - this means the ones, that
                                                    //didn't pass the check before
            {
                if (boolArr[i])
                {
                    Console.Write(i + " "); // print every member
                    result.Add(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} is the largest prime number", result[result.Count - 1]);
        }
    }
}

