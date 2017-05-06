using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SequenceInMatrix
{
    class Program
    {
        //We are given a matrix of strings of size N x M.   3 <= N, M <= 128
        //Sequences in the matrix we define as sets of several 
        //neighbour elements located on the same LINE, COLUMN or DIAGONAL.
        //Write a program that finds the longest sequence of equal strings
        //in the matrix and prints its length.

        static void Main()
        {
            { 
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);  //rows
                int m = int.Parse(input[1]);  //cols

                string[,] MasterMatrix = new string[n, m]; //create Matrix from user's values
                for (int row = 0; row < n; row++)
                {
                    string[] tempStr = Console.ReadLine().Split(' ');
                    for (int col = 0; col < m; col++)
                    {
                        MasterMatrix[row, col] = tempStr[col];
                    }
                }

                int[,] longestSequenceMatrix = new int[n, m]; //this matrix will keep only the number of equal elements. This is "dynamic programing" technique. See: 01.Arrays\18.RemoveElementsFromArray
                for (int row = 0; row < n; row++) //define all element with value "1"
                {
                    for (int col = 0; col < m; col++)
                    {
                        longestSequenceMatrix[row, col] = 1;
                    }
                }

                //calculation
                MasterMatrixCalculation(n, m, MasterMatrix, longestSequenceMatrix);
                //print
                int result = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        if (result < longestSequenceMatrix[row, col])// if there is longestSequenceMatrix >0
                        {
                            result = longestSequenceMatrix[row, col];
                        }
                    }
                }
                Console.WriteLine(result); // print result = longestSequenceMatrix[row, col];
            }
        }
        static void MasterMatrixCalculation(int n, int m, string[,] MasterMatrix, int[,] longestSequenceMatrix)
        {
            // go trough matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    //create a sub matrix for check each element of master matrix
                    //top side
                    for (int top = 0; top < 3; top++)
                    {
                        if (((row - 1) < 0) || (((col - 1) + top < 0) || (((col - 1) + top) > m - 1)))
                        {
                            continue;
                        }
                        else
                        {
                            if (MasterMatrix[(row - 1), ((col - 1) + top)] == MasterMatrix[row, col])
                            {
                                longestSequenceMatrix[row, col] += longestSequenceMatrix[(row - 1), ((col - 1) + top)];
                                longestSequenceMatrix[(row - 1), ((col - 1) + top)] = 0;
                            }
                        }
                    }
                    //right side
                    if (!((col + 1) > m - 1))
                    {
                        if (MasterMatrix[row, (col + 1)] == MasterMatrix[row, col])
                        {
                            longestSequenceMatrix[row, col] += longestSequenceMatrix[row, (col + 1)];
                            longestSequenceMatrix[row, (col + 1)] = 0;
                        }
                    }
                    //left side
                    if (!((col - 1) < 0))
                    {
                        if (MasterMatrix[row, (col - 1)] == MasterMatrix[row, col])
                        {
                            longestSequenceMatrix[row, col] += longestSequenceMatrix[row, (col - 1)];
                            longestSequenceMatrix[row, (col - 1)] = 0;
                        }
                    }
                    //bottom side
                    for (int bottom = 0; bottom < 3; bottom++)
                    {
                        if (((row + 1) > n - 1) || (((col - 1) + bottom < 0) || (((col - 1) + bottom) > m - 1)))
                        {
                            continue;
                        }
                        else
                        {
                            if (MasterMatrix[(row + 1), ((col - 1) + bottom)] == MasterMatrix[row, col])
                            {
                                longestSequenceMatrix[row, col] += longestSequenceMatrix[(row + 1), ((col - 1) + bottom)];
                                longestSequenceMatrix[(row + 1), ((col - 1) + bottom)] = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}