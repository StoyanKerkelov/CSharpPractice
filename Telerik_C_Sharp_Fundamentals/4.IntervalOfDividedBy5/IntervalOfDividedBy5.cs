using System;


namespace _4.IntervalOfDividedBy5
{
    class IntervalOfDividedBy5
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            int count = 0;
            for (long i = (start + 1); i < end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
