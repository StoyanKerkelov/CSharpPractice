using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.Write("{0:F2} ", Math.PI * 2 * r);//Perimeter
            Console.WriteLine("{0:F2}", Math.PI * r * r);//Area
        }
    }
}
