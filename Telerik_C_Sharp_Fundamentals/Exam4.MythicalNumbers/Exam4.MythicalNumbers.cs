using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4.MythicalNumbers
{
    class Program
    {
    /*
    You are given a POSITIVE number that is 3 digits long. Depending on the 3rd digit,
    you need to perform some calculations.
     * If the 3rd digit is zero, find the product of the first two digits.
     * If the 3rd digit is between 0 and 5 inclusive, find the product of the first two
     digits and divide the result by the 3rd digit.
     * If the 3rd digit is larger than 5, find the sum of the first two digits and 
     multiply the result by the 3rd digit.
     */
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            float digit1 = number / 100 % 10;
            float digit2 = number / 10 % 10;
            float digit3 = number / 1 % 10;
            float result;

            if (digit3 == 0)                        // find the product of the first two digits.
            {
                result = digit1 * digit2;
            }
            else if (0 < digit3 && digit3 <= 5)     // find the product of the first two digits and 
            {                                       //divide the result by the 3rd digit.
                result = (digit1 * digit2) / digit3;
            }
            else    //find the sum of the first two digits and multiply the result by the 3rd digit.
            {
                result = (digit1 + digit2) * digit3;
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
