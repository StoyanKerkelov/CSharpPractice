using System;

namespace _6.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {

            long dec = long.Parse(Console.ReadLine());

            long rest;
            string binary = string.Empty;

            while (dec > 0)
            {
                rest = dec % 2;
                dec /= 2;
                binary = rest.ToString() + binary;// first the newly made result then the old string
            }

            Console.WriteLine(binary);

        }
    }
}
