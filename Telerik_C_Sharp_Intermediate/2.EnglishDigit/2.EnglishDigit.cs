using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnglishDigit
{
    class Program
    {   //Write a method that returns the last digit of given integer as an English word. 
        //Write a program that reads a number and prints the result of the method.
        static string dafaq(int digit)
        {
            //string[] array = { "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string result;
            switch (digit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "tree";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                default:
                    result = "zero";
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int digit = input % 10;
            Console.WriteLine(dafaq(digit));
        }
    }
}
