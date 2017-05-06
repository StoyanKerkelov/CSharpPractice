using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LeapYear
{
    class Program
    {   // Write a program that reads a year from the console and checks whether it is a leap one.
        // Hint: Use System.DateTime.
        static void Main()
        {
            // input
            //Console.WriteLine("Please insert the current year in YYYY format: ");
            int currentYear = int.Parse(Console.ReadLine());

            // creating a DateTime object (at least 3 parameters necessary)
            DateTime newDate = new DateTime(currentYear, 1, 1);

            // printing
            Console.WriteLine("{0} {1} a leap year.", newDate.Year, DateTime.IsLeapYear(newDate.Year) ? "is" : "is not");
        }
    }
}
