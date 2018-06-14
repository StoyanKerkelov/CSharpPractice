using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.NumberOfPages
{
    class Program
    {
        /*
        A book has N pages, numbered from 1 to N (1, 2, 3, ... N - 1, N).
        The total number of digits in the page numbers is 1 <D< 1,000,00.
        How many pages does the book have? Write a program to find the number N.
        */
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            for (int page = 1; digits != 0; pages++)//while there still exists 'digits'
            {
                pages++;                            //add 1 to 'pages' count
                digits -= page.ToString().Length;   // take off 'digits' the length of the counted page
                                                    //when you count the XXXth page you remove 3 form digits and so on
            }
            Console.WriteLine(pages);
        }
    }
}
