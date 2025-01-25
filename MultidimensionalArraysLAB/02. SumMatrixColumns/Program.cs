using System;

namespace _02._SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            //populating the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            //calculating the matrix by columns
            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                for(int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
