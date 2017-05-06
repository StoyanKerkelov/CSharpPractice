using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BinarySearch
{
    class Program
    {
        //Write a program, that reads from the console an array of N integers and an integer K,
        //sorts the array and using the method Array.BinSearch()
        //finds the largest number in the array which is ≤ K.
        /*Готовият метод в C# е Array.BinarySearch. Характерно за него е, че ако търсеният елемент го няма в масива,
то тогава BinarySearch връща отрицателно число (ако върнатата стойност е по-голяма или равна на нула, 
то търсения елемент съществува в масива). Ако методът върне отрицателно число бихме могли с помощта 
на побитовия оператор “~” да намерим индекса на първия елемент по-голям от търсения. Правим си три if проверки, за да можем да покрием всички
евентуални върнати стойности от BinarySearch-а.*/
        static void Main()
        {

            int[] array = { 8, 1, 0, 2, 3, 6, 6, 17, 12, 14, 5, 1, 38, 16, 19, 22, 31, 28, 6 };
            Console.WriteLine("Please Enter K number: ");
            int K = int.Parse(Console.ReadLine());

            Array.Sort(array);

            int searchedNumber = Array.BinarySearch(array, K);
            foreach (int number in array)
            {
                Console.Write(number + " ");//preview of the sorted array
            }
            Console.WriteLine();

            if (searchedNumber < -1)
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);//bitwise NOT ~ switch every bit of the number example '0011' to '1100'
            }
            else if (~searchedNumber == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
            }
        }
    }
}
