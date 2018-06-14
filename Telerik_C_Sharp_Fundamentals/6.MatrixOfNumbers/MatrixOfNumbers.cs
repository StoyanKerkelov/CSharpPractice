using System;

namespace _6.MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 0 || num > 21)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for ( int i=0; i<num; i++)
                {
                    for (int j = i+1; j <= num+i; j++)
                    {
                        Console.Write(j + " "); //row
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
