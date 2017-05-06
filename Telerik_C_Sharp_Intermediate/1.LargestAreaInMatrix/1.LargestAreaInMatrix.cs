using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LargestAreaInMatrix
{
    class Program
    {
        //Write a program that finds the largest area of equal neighbour elements
        //in a rectangular matrix and prints its size.
        //Hint: you can use the algorithm Depth-first search or Breadth-first search.
        /*Обхождане в дълбочина (на английски: Depth-First Search (DFS)) е алгоритъм за обхождане на 
         * структури от данни, и по-специално дърво и граф. За реализация на алгоритъма се избира
         * даден връх (възел) от структурата, който се обозначава като корен (връх без предшественици)
         * и обхождането стартира от него. Последователно се посещават всички следващи върхове до 
         * достигането на връх без наследници (от който не излизат ребра), след което се осъществява
         * търсене с връщане назад (на англ. backtracking) до достигане на нова крайна точка или при
         *  цялостно реализирано обхождане - към корена.
        Шарл Пиер Тремо прилага версия на алгоритъма през 19-ти век за решаване на задачи с лабиринти.
         */
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);  //rows
            int m = int.Parse(input[1]);  //cols

            int [,] array = new int[n, m]; //create Matrix from user's values
            for (int row = 0; row < n; row++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                int[] tempStrInt = Array.ConvertAll(tempStr, int.Parse);
                for (int col = 0; col < m; col++)
                {
                    array[row, col] = tempStrInt[col];
                }
            }
            /////////////////////////////////////////////////
            /*int[,] array = new int[,] { {1,3,2,2,2,4},    //original example
                                    {3,3,3,2,4,4},
                                    {4,3,1,2,3,3},
                                    {4,3,1,3,3,1},
                                    {4,3,3,3,1,1} };*/
            bool[,] calculated = new bool[array.GetLength(0), array.GetLength(1)];// create bool[n,m]
            int bestCount = 0;
            int indexRow = 0;
            int indexCol = 0;
            for (int row = 0; row < array.GetLength(0); row++)//from rows
            {
                for (int col = 0; col < array.GetLength(1); col++)//trough cols
                {
                    if (!calculated[row, col])//at begin all calculated values are false
                    {
                        int count = DepthFirstSearch(array, row, col, calculated);
                        if (bestCount < count)//if bestCount<count(result form method)
                        {
                            bestCount = count;// used in DepthFirstSearch()
                            indexRow = row;// used in DepthFirstSearch()
                            indexCol = col;// used in DepthFirstSearch()
                        }
                    }

                }
            }
            Console.WriteLine("The len of largest area in matrix is {0}", bestCount);
            Console.WriteLine("The element is {2} on position {0},{1} ", indexRow, indexCol, array[indexRow, indexCol]);
        }

        static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
        {
            /*
             В стек се задава началният връх.
            Докато в стека има върхове:
            Изважда се връх от стека
            Прави се проверка в списъка с обходените и ако върхът не е обходен:
            Обхожда се и се поставя в списъка с обходените.
            Вмъкват се всички върхове, към които той има ребро в стека.
             */
            int result = 1;
            calc[row, col] = true;
            if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
            {
                result += DepthFirstSearch(array, row - 1, col, calc);
            }
            if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
            {
                result += DepthFirstSearch(array, row + 1, col, calc);
            }
            if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
            {
                result += DepthFirstSearch(array, row, col - 1, calc);
            }
            if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
            {
                result += DepthFirstSearch(array, row, col + 1, calc);
            }
            return result;
        }
    }
}
