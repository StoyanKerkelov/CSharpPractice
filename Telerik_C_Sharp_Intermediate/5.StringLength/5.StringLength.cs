using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.StringLength
{
    class Program
    {   //Write a program that reads from the console a string of maximum 20 characters. 
        //If the length of the string is less than 20, the rest of the characters should be filled with *.
        static void Main()
        {
            Console.WriteLine("Enter text: ");

            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            if (input.Length >= 20)
            {
                for (int counter = 0; counter < 20; counter++)
                {
                    output.Append(input[counter]);
                }
            }
            else
            {
                output.Append(input);
                for (int counter = input.Length; counter < 20; counter++)
                {
                    output.Append("*");
                }
            }

            Console.WriteLine("First 20 symbols (if less will be filled with *): \n{0}", output.ToString());
        }
    }
}
