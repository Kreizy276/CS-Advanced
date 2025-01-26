using System;
using System.Linq;

namespace _01._DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            ReadMatrix(ref matrix);

            int sum1 = 0;
            int sum2 = 0;

            for(int row = 0; row < n; row++)
            {
                sum1 += matrix[row, row];
                sum2 += matrix[row, n - row - 1];
            }

            int absoluteValue = Math.Abs(sum1 - sum2);
            Console.WriteLine(absoluteValue);
        }

        static void ReadMatrix(ref int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
