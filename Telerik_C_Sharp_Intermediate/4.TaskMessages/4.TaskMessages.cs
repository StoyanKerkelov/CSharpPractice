using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Numerics;

namespace _4.TaskMessages
{   /* calculate the result of the operation, by given two numbers
    in GeorgeTheGreat numeral system and an operator (subtraction or addition
        The number of digits in any number will always be less or equal to 8192 (2^13)
        The second number will always be smaller or equal than the first
     example:
                markoncykyanogi
                -
                cykyan
                result=>markoncykmaryan
     */
    class Program
    {
        static string[] numSystem = { "cad", "xoz", "nop", "cyk", "min", "mar",
            "kon", "iva", "ogi", "yan" };
        static void Main()
        {
            string strOne = Console.ReadLine();
            string op = Console.ReadLine();
            string strTwo = Console.ReadLine();

            BigInteger numOne = Decrypt(strOne);
            BigInteger numTwo = Decrypt(strTwo);
            BigInteger numResult = (op == "+" ? numOne + numTwo : numOne - numTwo);
            string result = Encrypt(numResult);
            Console.WriteLine(result);
        }
        private static BigInteger Decrypt(string str)
        {
            BigInteger result = 0;

            string digit;
            for (int j = 0; j < str.Length; j+=3)
            {
                digit = str.Substring(j, 3);
                result = result * 10 + Array.IndexOf(numSystem, digit);
                //for (int i = 0; i < numSystem.Length; i++)
                //{
                //    if (digit == numSystem[i])
                //    {
                //        result = result * 10 + i;
                //    }
                //}
            }
            return result;
        }
            private static string Encrypt(BigInteger num)
        {
            string result = "";
            int digit = 0;
            while (num > 0)
            {
                digit = (int)(num % 10);
                result = numSystem[digit] + result;
                num /= 10;
            }
            return result;
        }
    }
}
