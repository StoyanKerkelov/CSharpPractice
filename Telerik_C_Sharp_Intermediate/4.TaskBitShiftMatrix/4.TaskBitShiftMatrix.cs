using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.TaskBitShiftMatrix
{
    class Program
    {
        static void Main()
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());
            int movesCount = int.Parse(Console.ReadLine());

            List<int> moves = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var visitedMatrix = new bool[rowsCount, colsCount];
            CycleMatrix(visitedMatrix, moves);
            var sum = CalulateSum(visitedMatrix);
            Console.WriteLine(sum);
        }
        static void CycleMatrix(bool[,] visitedMatrix, List<int> moves)
        {
            int col = 0;
            int row = visitedMatrix.GetLength(0) - 1;
            int coef = Math.Max(visitedMatrix.GetLength(0), visitedMatrix.GetLength(1));

            foreach (int move in moves)
            {
                int targetRow = move / coef;
                int targetCol = move % coef;
                while (col != targetCol)
                {
                    visitedMatrix[row, col] = true;
                    if (col < targetCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }
                while (row != targetRow)
                {
                    visitedMatrix[row, col] = true;
                    if (row < targetRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }
                visitedMatrix[row, col] = true;
            }
        }
        static BigInteger CalulateSum(bool[,] visitedMatrix)
        {
            int rowsCount = visitedMatrix.GetLength(0);
            int colCount = visitedMatrix.GetLength(1);
            BigInteger sum = 0;

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    if (visitedMatrix[row, col])
                    {
                        sum += (BigInteger)1 << (rowsCount - row - 1 + col);
                    }
                }
            }
            return sum;
        }
    }
}
