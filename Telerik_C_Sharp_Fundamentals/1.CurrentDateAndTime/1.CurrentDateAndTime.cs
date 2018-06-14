using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CurrentDateAndTime
{
    class Program
    {
        static void Main()
        {
            //create a console application that prints the current date and time. 

            DateTime dt = DateTime.Now;
            CultureInfo ci = new CultureInfo("en-US");

            Console.WriteLine(dt.ToString(ci));
        }
    }
}

