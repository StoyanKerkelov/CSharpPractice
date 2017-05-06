using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DayOfWeek
{
    class Program
    {//Write a program that prints to the console which day of the week is today. Use System.DateTime.
        static void Main()
        {
            DateTime dayOfWeek = new DateTime();

            dayOfWeek = DateTime.Now;
            Console.WriteLine("Today is: {0}\n", dayOfWeek.DayOfWeek);
        }
    }
}
