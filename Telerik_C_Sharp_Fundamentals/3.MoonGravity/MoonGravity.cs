using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double W = (double.Parse(Console.ReadLine()));
            W = W * 0.17;
            Console.WriteLine(W.ToString("0.000"));
        }
    }
}
