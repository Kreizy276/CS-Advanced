using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split();
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (IsValidIndex(row, col, matrix))
                {
                    if (action == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }
            PrintMatrix(matrix);
        }
        static bool IsValidIndex(int row, int col, int[][] matrix)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
        static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
