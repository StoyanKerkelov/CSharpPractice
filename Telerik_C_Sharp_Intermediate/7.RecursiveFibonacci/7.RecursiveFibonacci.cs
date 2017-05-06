using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RecursiveFibonacci
{
    /*Можем да оптимизираме рекурсивния метод за изчисление на числата на Фибоначи, като 
    записваме вече пресметнатите числа в масив и извършваме рекурсивно извикване само ако 
    числото, което пресмятаме, не е било вече пресметнато до момента. Благодарение на тази 
    малка оптимизационна техника (известна в компютърните науки и в динамичното оптимиране с 
    термина "memoization" ), рекурсивното решение ще работи за линеен брой стъпки.*/

    static long[] numbers;
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        numbers = new long[n + 2];
        numbers[1] = 1;
        numbers[2] = 1;
        long result = Fib(n);
        Console.WriteLine("fib({0}) = {1}", n, result);
    }
    static long Fib(int n)
    {
        if (0 == numbers[n])
        {
            numbers[n] = Fib(n - 1) + Fib(n - 2);
        }
        return numbers[n];
    }
}
