using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SumIntegers
{   //You are given a sequence of positive integer values written into a string,
    //separated by spaces. Write a function that reads these values from given 
    //string and calculates their sum
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int sum = 0;
            foreach (string p in numbers)
            {
                sum += int.Parse(p);
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

