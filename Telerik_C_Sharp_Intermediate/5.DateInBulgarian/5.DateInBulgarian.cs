using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _5.DateInBulgarian
{
    class Program
    {   //Write a program that reads a date and time given in the format:
        //day.month.year hour:minute:second 
        //and prints the date and time after 6 hours and 30 minutes (in the same format) 
        //along with the day of week in Bulgarian.

        static void Main()
        {
            string input = @"07.08.1994 03:47:22";

            DateTime dateSample = DateTime.ParseExact(input, "dd.MM.yyyy hh:mm:ss", new CultureInfo("bg-BG"));

            Console.WriteLine("Original date: {0}", dateSample);
            Console.WriteLine("Time after 6 and a half hours: {0}", dateSample.AddHours(6.5));
            Console.WriteLine("Day of week: {0}", dateSample.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}

