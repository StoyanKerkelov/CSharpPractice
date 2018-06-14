using System;
namespace NBit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            long moveBit = number >> position;
            long foundBit = moveBit & 1;
            bool isOne = foundBit == 1;
            if (isOne)
            {
                Console.WriteLine("1");
            }
 else 
{
                Console.WriteLine("0");
            }
        }
    }
}