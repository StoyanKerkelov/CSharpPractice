using System;
namespace WhatIsMyAge
{
    class WhatIsMyAge
    {
        static void Main()
        {
            //Console.WriteLine("Please enter date of Birth in format MM.DD.YYYY: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            //Console.WriteLine("Today's current date is: ");
            //Console.WriteLine("{0}", now);
           
            int Age = now.Year - dob.Year;
            if (now.Month <= dob.Month && now.Day < dob.Day)
            {
                Age--;
            }

            //Console.WriteLine("Your age is: ");
            Console.WriteLine("{0}", Age);
            //Console.WriteLine("Your age after 10 years from now will be: ");
            Console.WriteLine("{0}", Age+10);
        }
    }
}
