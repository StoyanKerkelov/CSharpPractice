using System;

namespace OddOrEven
{
    class OddorEven
    {
        static void Main()
        {
            int num  = (int.Parse(Console.ReadLine()));

            if (num % 2 == 0)
                Console.WriteLine("even " + num);
            else
                Console.WriteLine("odd " + num);

        }
    }
}
