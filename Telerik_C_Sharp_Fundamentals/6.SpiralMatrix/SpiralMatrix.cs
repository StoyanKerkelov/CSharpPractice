using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SpiralMatrix
{
    class SpiralMatrix
    {
        //Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20)
        //and prints a matrix holding the numbers from 1 to N*N in the form of square spiral 
        //like in the examples below.
        //The order of numbers in clock-wise!! example: intput => 4 output=> |1|2|
        //                                                                   |4|3|
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];  //using Multidimensional arrays
            int row = 0;
            int col = 0;
            string direction = "right"; // starting direction of print is right
            int maxRotations = n * n; // all the steps in the loop

            for (int i = 1; i <= maxRotations; i++) //for every step of the loop map the matrix indexes
            {                                       //change the direction accordingly
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {//if we come to col border n-1 change direction right->down!
                    direction = "down";
                    col--;//remove one col
                    row++;// add one row
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {//if we come to row border n-1 change direction down->left!
                    direction = "left";
                    row--;//remove one row
                    col--;// remove one col
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {//if we come to col border 0 change direction left->up!
                    direction = "up";
                    col++;// add one col
                    row--;// remove one row
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {//if we come to row border 0 change direction up->right!
                    direction = "right";
                    row++;// add one row
                    col++;// add one col
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;//moving right increase also height of matrix
                }
                if (direction == "down")
                {
                    row++;//moving down increase also length of matrix
                }
                if (direction == "left")
                {
                    col--;//moving left decrease heigth of matrix
                }
                if (direction == "up")
                {
                    row--;//moving down decrease length of matrix
                }
            }

            // Display Matrix

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,3}", matrix[r, c]);//load the sequence [1 ... n*n]
                }                                       //according to the maped indexes
                Console.WriteLine();
            }

        }
    }
}
