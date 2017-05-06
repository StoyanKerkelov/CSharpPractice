using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SortByStringLength
{
    class Program
    {
        //You are given an array of strings. Write a method that sorts the array
        //by the length of its elements (the number of characters composing them).
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] array = { "Messi", "RobinVanPersie", "Berbatov", "Isko", "HristoStoichkov" };
            Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
