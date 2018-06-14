using System;

namespace ConsoleInputOutput
{
    public static class SumOfN_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            decimal number = decimal.MinValue;  // prevents overflow
            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
            
        }
    }
}