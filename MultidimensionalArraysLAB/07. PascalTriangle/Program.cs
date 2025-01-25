using System;

namespace _07._PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] pascalTriangle = new int[size][];

            for (int row = 0; row < size; row++)
            {
                int[] line = new int[row + 1];
                pascalTriangle[row] = line;

                line[0] = 1;
                line[row] = 1;

                for (int col = 1; col < row; col++)
                {
                    line[col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write(pascalTriangle[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
