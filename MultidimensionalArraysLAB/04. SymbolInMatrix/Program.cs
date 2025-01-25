using System;
using System.Transactions;

namespace _04._SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            //reading a matrix
            for(int row = 0; row < n; row++)
            {
                string str = Console.ReadLine();
                char[] line = str.ToCharArray();

                for(int col =0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            //searching for the symbol within the matrix
            int currentRow = 0, currentCol = 0;
            bool isFound = false;
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFound = true;
                        currentRow = row;
                        currentCol = col;
                        break;
                    }
                }
                if (isFound) break;
            }
            Console.WriteLine(isFound ? $"({currentRow}, {currentCol})" : $"{symbol} does not occur in the matrix");
        }
    }
}
