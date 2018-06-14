using System;

namespace _6.MMSA
{
    class MMSA
    {
        static void Main()
        {
            int number_count = int.Parse(Console.ReadLine());
            double sum=0;
            double min=10000;
            double max=-10000;
            for (int i = 0; i < number_count; i++)
                
            {
                double number = Double.Parse(Console.ReadLine());
                sum += number;

                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;

                }
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:F2}", (sum / number_count));
        }
    }
}
