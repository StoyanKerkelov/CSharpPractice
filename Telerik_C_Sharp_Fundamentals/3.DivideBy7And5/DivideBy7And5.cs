using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if ((a % 7) == 0 && a % 5 == 0)
            {
                Console.WriteLine("true " + a);
            }
            else
            {
                Console.WriteLine("false " + a);
            }

        }
    }
}
