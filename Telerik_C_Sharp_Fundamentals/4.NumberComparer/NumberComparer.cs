using System;

namespace _4.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double firstValue = double.Parse(Console.ReadLine());
            double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine(firstValue <= secondValue ? secondValue : firstValue);
        }
    }
}
