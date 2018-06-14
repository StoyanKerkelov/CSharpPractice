using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        { 
            const double eps = 0.000001;
            double a = (double.Parse(Console.ReadLine()));
            double b = (double.Parse(Console.ReadLine()));
                if (Math.Abs(a - b) <= eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
        }
    }
}
