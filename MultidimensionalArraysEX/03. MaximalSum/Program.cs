using System;
using System.Linq;

namespace _03._MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0], cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            ReadMatrix(ref matrix);

            int result = 0, maxRow = 0, maxCol = 0;
            CalculatingMatrix(matrix, ref result, ref maxRow, ref maxCol);
            Console.WriteLine($"Sum = {result}");
            PrintMatrix(matrix, maxRow, maxCol);
        }
        static void CalculatingMatrix(int[,] matrix, ref int maxSum, ref int maxRow, ref int maxCol)
        {
            maxRow = 0;
            maxCol = 0;

            maxSum = int.MinValue;
            int result = 0;
            for(int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for(int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    result = 
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if(result > maxSum)
                    {
                        maxSum = result;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
        }
        static void PrintMatrix(int[,] matrix, int rowLength, int colLength)
        {
            for (int row = rowLength; row < rowLength + 3; row++)
            {
                for (int col = colLength; col < colLength + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static void ReadMatrix(ref int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
