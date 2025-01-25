using System;
using System.Linq;

namespace _03._PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            //reading a matrix
            for(int row = 0; row < n; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            //calculating the diagonal
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
