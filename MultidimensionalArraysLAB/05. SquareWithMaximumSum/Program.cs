using System;
using System.Linq;

namespace _05._SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            ReadMatrix(ref matrix);

            int maxSum = int.MinValue;
            int maxRow = 0, maxCol = 0;

            SummingMatrix(matrix, ref maxSum, ref maxRow, ref maxCol);

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
        static void ReadMatrix(ref int[,] matrix)
        {
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }

        static void SummingMatrix(int[,] matrix, ref int maxSum, ref int maxRow, ref int maxCol)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
        }
    }
}
