using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RecursiveNestedLoops
{   /* Write a program that simulates the implementation of N nested cycles from 1 to K,
     Where N and K are entered by the user.*/
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;
    static void Main()
    {
        Console.Write("N = ");
        numberOfLoops = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());
        loops = new int[numberOfLoops];
        NestedLoops(0);
    }
    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }
    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}
