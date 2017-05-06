using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MaximalSum
{
    //Write a program that reads a rectangular matrix of size N x M
    //and finds in it the square 3 x 3 that has maximal sum of its 
    //elements. Print that sum.
    //3 <= N, M <= 1024; Numbers in the matrix [ -1000, 1000 ]
    class Program
    {
        public static void Main()
        {   //input size:
            int[] fieldSizes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse).ToArray();
            int fieldHeight = fieldSizes[0];
            int fieldWidth = fieldSizes[1];
            int[,] field = new int[fieldHeight, fieldWidth];

            int maxSum = int.MinValue;
            ReadFieldNumbers(field, fieldHeight); //creates matrix
            for (int row = 0; row < field.GetLength(0) - 2; row++)// fallow upto lenght -3
            {
                for (int col = 0; col < field.GetLength(1) - 2; col++) // fallow upto heigth -3
                {
                    int currSum = field[row, col] + field[row, col + 1] + field[row, col + 2]
                       + field[row + 1, col] + field[row + 1, col + 1] + field[row + 1, col + 2]
                       + field[row + 2, col] + field[row + 2, col + 1] + field[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;//save maximum sum
                    }
                }
            }

            Console.WriteLine(maxSum);//print maximum sum
        }

        private static void ReadFieldNumbers(int[,] field, int rowsToRead)
        {
            for (int row = 0; row < rowsToRead; row++)
            {
                var currRow = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();//input values x_x_x_ with spaces of every row
                for (int col = 0; col < currRow.Length; col++)
                {
                    field[row, col] = currRow[col]; // make matrix from every instance of curr row[]
                }
            }
        }
    }
}
