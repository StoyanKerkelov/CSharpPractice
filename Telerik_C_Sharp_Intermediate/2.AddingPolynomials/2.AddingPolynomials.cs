using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddingPolynomials
{
    class Program
    {   //Write a method that adds two polynomials. Represent them as arrays of their coefficients. 
        //Write a program that reads two polynomials and PRINTS THEIR SUM.
        //On the first line you will receive the number N
        //On the second line you will receive the first polynomial as coefficients separated by spaces
        //On the third line you will receive the second polynomial as coefficients separated by spaces
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            /*string text = Console.ReadLine();
            arrOne = text
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            text = Console.ReadLine();
            var arrTwo = text
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray*/
            ////////////////////////////////////
            Console.WriteLine("Adding:");
            AddPolynomials(arrOne, arrTwo);
            Console.WriteLine("Substract:");
            SubstractPolynomials(arrOne, arrTwo);
            Console.WriteLine("Multiplicate:");
            MultiplicatePolynomials(arrOne, arrTwo);
        }
        static void AddPolynomials(int[] arrOne, int[] arrTwo)
        {
            int [] newArr = new int [arrOne.Length];
            Array.Copy(arrOne, newArr, arrOne.Length);

            for (int i = 0; i < arrOne.Length; i++)
            {
                newArr[i] += arrTwo[i];
            }
            var result = string.Join(" ", newArr);
            Console.WriteLine(result);
        }
        static void SubstractPolynomials(int[] arrOne, int[] arrTwo)
        {
            int[] newArr = new int[arrOne.Length];
            Array.Copy(arrOne, newArr, arrOne.Length);

            for (int i = 0; i < arrOne.Length; i++)
            {
                newArr[i] -= arrTwo[i];
            }
            var result = string.Join(" ", newArr);
            Console.WriteLine(result);
        }
        static void MultiplicatePolynomials(int[] arrOne, int[] arrTwo)
        {
            int[] newArr = new int[arrOne.Length];
            Array.Copy(arrOne, newArr, arrOne.Length);

            for (int i = 0; i < arrOne.Length; i++)
            {
                newArr[i] *= arrTwo[i];
            }
            var result = string.Join(" ", newArr);
            Console.WriteLine(result);
        }
    }
}
