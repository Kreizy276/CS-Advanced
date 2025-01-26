using System;

namespace _04._MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0], cols = rowsAndCols[1];

            string[,] matrix = new string[rows, cols];

            ReadMatrix(ref matrix);

            string command;
            while((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] splitter = command.Split();

                int row1 = 0, col1 = 0, row2 = 0, col2 = 0;

                bool isValid =
                    int.TryParse(splitter[1], out row1) &&
                    int.TryParse(splitter[2], out col1) &&
                    int.TryParse(splitter[3], out row2) &&
                    int.TryParse(splitter[4], out col2);

                bool validCoordinates = 
                    isValid && 
                    row1 >= 0 && row1 < matrix.GetLength(0) && 
                    col1 >= 0 && col1 < matrix.GetLength(1) &&
                    row2 >= 0 && row2 < matrix.GetLength(0) && 
                    col2 >= 0 && col2 < matrix.GetLength(1);

                if (!validCoordinates)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (splitter[0] == "swap")
                {
                    ShuffleMatrix(matrix, row1, col1, row2, col2);
                    PrintMatrix(matrix);
                }
            }
        }
        static string[,] ShuffleMatrix(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string temp = matrix[row1, col1];

            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;

            return matrix;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        static void ReadMatrix(ref string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = line[col];
            }
        }
    }
}
