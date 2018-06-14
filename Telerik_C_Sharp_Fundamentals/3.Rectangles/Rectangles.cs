using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a>0 && b>0)
            {
                double S = a * b;
                double P = (2 * a) + (2 * b);
                Console.WriteLine(S.ToString("0.00") + " " + P.ToString("0.00"));
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
