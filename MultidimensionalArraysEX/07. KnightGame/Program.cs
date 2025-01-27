using System;

namespace KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int removedKnights = 0;
            int[] knightMovesRow = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] knightMovesCol = { -1, 1, -2, 2, -2, 2, -1, 1 };

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            int attacks = CountAttacks(board, row, col, knightMovesRow, knightMovesCol);

                            if (attacks > maxAttacks)
                            {
                                maxAttacks = attacks;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    break;
                }

                board[maxRow, maxCol] = '0';
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }

        static int CountAttacks(char[,] board, int row, int col, int[] rowMoves, int[] colMoves)
        {
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                int newRow = row + rowMoves[i];
                int newCol = col + colMoves[i];

                if (IsInBounds(board, newRow, newCol) && board[newRow, newCol] == 'K')
                {
                    count++;
                }
            }
            return count;
        }

        static bool IsInBounds(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}
