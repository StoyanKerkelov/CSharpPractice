//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays

{

    static void Main()
    {
        int sumA = 0;
        int sumB = 0;

        string array1 = Console.ReadLine();
        string array2 = Console.ReadLine();

        // 1 char = 8 bit (1byte)  if  1< array <=128, then 
        // string <= 8x16 or string <= 128 chars

        if(array1.Length > 128|| array2.Length > 128)
        {
            Console.WriteLine("invalid output");
        }
        else
        {
            foreach (int a in array1)
            {
                sumA += a;
            }

            foreach (int b in array2)
            {
                sumB += b;
            }

            if (sumA > sumB)
            {
                Console.WriteLine(">");
            }
            else if (sumA < sumB)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }

        }


    }
}