using System;
using System.Linq;

namespace _2.AppearanceCount
{
    public class Program
    {
        //Write a method that counts HOW MANY TIMES given number appears in a given array.
        //Write a test program to check if the method is working correctly.
        //On the first line you will receive a number 1 <= N <= 1024 - the size of the array     
        //On the second line you will receive N numbers separated by spaces - the numbers in the array
        //On the third line you will receive a number X
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberToFind = int.Parse(Console.ReadLine());

            Console.WriteLine(CountNumber(length, array, numberToFind));
        }
        private static int CountNumber(int arrLength, int[] numbers, int x)
        {
            var counter = 0;
            for (int i = 0; i < arrLength; i++)
            {
                if (numbers[i] == x)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}