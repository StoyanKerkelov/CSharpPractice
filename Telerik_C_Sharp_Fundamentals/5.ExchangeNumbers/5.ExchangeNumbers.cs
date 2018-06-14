using System;

namespace ExchangeNumbers
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                double storeB = A;//exchange values
                double storeA = B; //exchange values
                Console.WriteLine("{0} {1}", storeA, storeB);
            }
            else if (A == B)
            {
                double storeA = A;
                double storeB = B;
                Console.WriteLine("{0} {1}", storeA, storeB);
            }
            else //A<B
            {
                double storeA = A;
                double storeB = B;
                Console.WriteLine("{0} {1}", storeA, storeB);
            }
        }
    }
}
