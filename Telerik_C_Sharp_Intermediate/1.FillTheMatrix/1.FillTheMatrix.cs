using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillTheMatrix
{
    class FillTheMatrix
    {
        //Write a program that fills and prints a matrix of size (n, n) as shown below.
        //1 <= N <= 128 (byte 0 255)
        static void Main()
        {
            Console.WriteLine("please decide what type of matrix (a, b, c or d) to you want:");
            string typeM = Console.ReadLine();

            if (typeM == "a") { aMethod(); }
            else if (typeM == "b") { bMethod(); }
            else if (typeM == "c") { cMethod(); }
            else if (typeM == "d") { dMethod(); }
            else { Console.WriteLine("No such type of matrix"); }
        }
        /////////////////////////////////
        static void aMethod()
        {
            string strNum;
            int n;
            do
            {
                Console.Write("Enter the size: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number
            int[,] array = new int[n, n];
            int counter = 1;
            // Fill it
            for (int row= 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    array[col, row] = counter; // fill first one col, then row
                    counter++;
                }
            }

            // Show the matrix

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);//print in usual order
                }
                Console.WriteLine();
            }
        }
        ////////////////////////////////
        static void bMethod()
        {
            Console.Write("Enter the size: ");
            int n;
            string strNum;
            do
            {
                Console.Write("Enter the size: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number
            int[,] matrixB = new int[n, n];
            int counter = 1;
            for (int col = 0; col < n; col++)//move trough column
            {
                if (col % 2 == 0)//for every EVEN column add increasing value upwards
                {
                    for (int row = 0; row < n; row++)//
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
                else    //for every ODD column 
                {
                    for (int row = n - 1; row >= 0; row--)//add increasing value downwards
                    {
                        matrixB[row, col] = counter;
                        counter++;
                    }
                }
            }
            //print in regular order
            for (int a = 0; a < matrixB.GetLength(0); a++)
            {
                for (int b = 0; b < matrixB.GetLength(1); b++)
                {
                    Console.Write("{0,3}", matrixB[a, b]);
                }
                Console.WriteLine();
            }
        }
        ////////////////////////////////
        static void cMethod()//fill diagonally from left to right
        {
            string strNum;
            int n;
            do
            {
                Console.Write("Enter the size: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number
            int[,] array = new int[n, n];
            int counter = 1;

            for (int i = n - 1; i >= 0; i--)// upwards from lowest row
            {
                for (int col = 0; col < n - i; col++)//leftwards to rightest possible check
                {
                    array[i + col, col] = counter++;//add value at [(row+x), x] {diagonally to the left}
                }
            }
            for (int j = 1; j < n; j++)// for column from left to right
            {
                for (int row = 0; row < n - j; row++)// row from leftwards to rightest possible check
                {                                    //counter continues from before
                    array[row, j + row] = counter++;//add value at [x, (row+x)] {diagonally to the left}
                }
            }

            // Print the matrix regularly

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        ////////////////////////////////
        static void dMethod()//counterclockwise
        {
            string strNum;
            int n;
            do
            {
                Console.Write("Enter the size: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out n)); // check if it is a real number
            int[,] array = new int[n, n];
            int counter = 1;
            int start = 0;
            int end = n;

            do //do while { end - (start++) > 0 } loop
            {
                for (int row = start; row < end; row++)// from col[0...n]
                {
                    array[row, start] = counter;//fill downwords first COLUMN
                    counter++;
                }

                for (int col = start + 1; col < end; col++)//from row[1...n]
                {
                    array[end - 1, col] = counter;//fill rightwords last ROW
                    counter++;
                }

                for (int row = end - 2; row >= start; row--)
                {
                    array[row, end - 1] = counter;// fill upwords from row [n-1-1...0]  (n-1 the last one -1 already taken)
                    counter++;
                }

                for (int col = end - 2; col >= start + 1; col--)//fill leftwards from col [n-1-1...0]  (n-1 the last one -1 already taken)
                {
                    array[start, col] = counter;
                    counter++;
                }
                start++;    // start next round counting from 1
                end--;      // start next round with border-- 
            }
            while (end - start > 0);

            // Show that matrix regularly
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}



