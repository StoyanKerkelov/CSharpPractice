using System;


namespace _6.NotDivisibleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (( i%3==0) || (i % 7 == 0))
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}
