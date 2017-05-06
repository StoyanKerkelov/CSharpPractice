using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SquareRoot
{
    class Program
    {
        static void Main()
        {/* Write a program that reads a number and calculates and prints its square root.

            If the number is INVALID or NEGATIVE, print Invalid number.
            In all cases finally print Good bye. Use try-catch-finally block.
         */
            try
            {
                Console.WriteLine("Enter integer number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Square root of {0} is: {1:F4}", number, Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a valid number!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Number must be positive!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
