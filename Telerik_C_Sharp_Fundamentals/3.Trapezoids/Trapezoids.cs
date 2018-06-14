using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());// double precision is 7 digits !!!
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && h>0)
            {
                double S = (((a + b)/2)*h);
                Console.WriteLine("{0:F7}", S);
            }
            else
            {
                Console.WriteLine("invalid output!");
            }

        }
    }
}
