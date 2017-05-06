using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumberAsArray
{
    class Program
    {   /* Write a program that reads two arrays representing positive integers
        and outputs their sum.
        On the first line you will receive two numbers separated by spaces - the size of each array
        On the second line you will receive the first array (Digits should be separated by spaces in reversed order)
        On the third line you will receive the second array (Digits should be separated by spaces in reversed order)
                    Input:
                    3 4
                    8 3 3       8 3 3 = 338
                    6 2 4 2     6 2 4 2 = 2426
                    Output:
                    4 6 7 2     338 + 2426 = 2764 
        */
        static void AddingCarryovers(int[] num0, int[] num1, int firstLength, int secondLength, int[] result, int carryover)
        {            
            for (int i = secondLength; i<firstLength; i++)//start from the smaller up  to the bigger
            {
                 result[i] = (num0[i] + carryover) % 10;// add value
                 carryover = (num0[i] + carryover) / 10;
            }
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstLength = input[0];
            int secondLength = input[1];
            int[] num0 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//up to here input
            int[] result = new int[Math.Max(firstLength, secondLength) + 1];
            // Fill result[]
            int carryOver = 0;
            for (int i = 0; i < Math.Min(firstLength, secondLength); i++)
            {
                result[i] = (num0[i] + num1[i] + carryOver) % 10;// take result without carryover 
                carryOver = (num0[i] + num1[i] + carryOver) / 10;//calc the carryover* (*edno na um)
            }

            if (firstLength > secondLength)//first number is bigger then the second one
            { AddingCarryovers(num0, num1, firstLength, secondLength, result , carryOver); }

            if (firstLength > secondLength)//second number is bigger then the first one
            { AddingCarryovers(num0, num1, secondLength, firstLength, result , carryOver); }

            result[Math.Max(firstLength, secondLength)] = carryOver;
            //Print the result without leading zeros
            for (int i = 0; i < result.Length; i++)
            {
                if (i + 1 == result.Length)
                {
                    if (result[i] == 0)
                    {
                        continue;// write untill the before-last element is not zero
                    }
                }

                Console.Write(result[i] + " ");
            }
        }
    }
}
