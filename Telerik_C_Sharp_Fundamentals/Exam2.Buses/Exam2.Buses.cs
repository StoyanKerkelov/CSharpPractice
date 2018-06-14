using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Buses
{
    class Program
    {
        /*
        Given the sequence of the speeds of the buses (buscount 1<C<1000,
        then every speed parsed individually on new line between 1 and 1500),
        print on the console (single int) the number of groups that are formed.
        
        Buses cannot outrun buses in front of them. If bus A is moving faster
        and reaches a bus B that is moving slower, then A must lower its speed to 
        match that of B. Buses with equal speeds does not form a single group - 
        they form different groups.
        */
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int groups = 0;

            int groupSpeed = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                int busSpeed = int.Parse(Console.ReadLine());

                if (busSpeed <= groupSpeed) //Buses with equal speeds form different groups!
                {
                    groups++;
                    groupSpeed = busSpeed;
                }
            }
            Console.WriteLine(groups);
        }
    }
}
