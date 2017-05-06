using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Workdays
{
    //Write a method that calculates the number of workdays between today and a given date,
    //passed as parameter. Consider that workdays are all days from Monday to Friday except
    //a fixed list of public holidays specified preliminary as array.
    class WorkingDays
    {
        static List<DateTime> holidays = new List<DateTime>();
        private static void FillDates(int year, int month, int day)//fill
        {
            DateTime holiday = new DateTime(year, month, day);
            holidays.Add(holiday);
        }
        private static void GetHolidays(DateTime futureDay)// get all holidays
        {
            for (int i = 2013; i <= futureDay.Year; i++)
            {
                FillDates(i, 1, 1);
                FillDates(i, 3, 3);
                FillDates(i, 5, 1);
                FillDates(i, 5, 6);
                FillDates(i, 5, 24);
                FillDates(i, 9, 6);
                FillDates(i, 9, 22);
                FillDates(i, 11, 1);
                FillDates(i, 12, 24);
                FillDates(i, 12, 25);
                FillDates(i, 12, 26);
            }
        }
        private static bool IsHoliday(DateTime currentDate)//check holiday
        {
            if (holidays.Contains(currentDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static int GetWorkingDays(DateTime futureDate)//count all days from beginning to input exclude non-working days
        {
            int workingDays = 0;
            DateTime currentDate = DateTime.Now;
            while (currentDate < futureDate)
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (!IsHoliday(currentDate))// for every non holiday or weekend counter++
                    {
                        workingDays++;
                    }
                }
                currentDate = currentDate.AddDays(1);
            }
            return workingDays;
        }
        static void Main()
        {
            Console.WriteLine("This program calculates the number of workdays between today and given date.\n");
            Console.WriteLine("Please enter the day to which you want to calculate the working days.");
            Console.Write("The format should be as follows YYYY-MM-DD: ");
            DateTime futureDate;//create datetime "futureDate"
            int workingDays = 0;// start counter from 0
            if (DateTime.TryParse(Console.ReadLine(), out futureDate))
            {
                GetHolidays(futureDate);// get all holidays up to futureDate
                workingDays = GetWorkingDays(futureDate);//count all days from beginning to input exclude non-working days
                Console.WriteLine("\nThe working days between today and the date you have just specified are: {0}\n", workingDays);
            }
            else
            {
                Console.WriteLine("\nWrong input.\n");
            }
        }
    }
}
