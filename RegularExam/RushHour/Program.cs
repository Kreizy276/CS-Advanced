namespace RushHour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];

            char[,] grid = new char[rows, cols];

            Dictionary<string, (int, int)> directions = new()
            {
                ["up"] = (-1, 0),
                ["right"] = (0, 1),
                ["down"] = (1, 0),
                ["left"] = (0, -1)
            };

            // reading matrix
            for (int i = 0; i < rows; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = line[j];
                }
            }

            bool deliveryCompleted = false;

            (int startRow, int startCol) = FindStartingPostion(grid);
            (int endRow, int endCol) = FindDeliveryPoint(grid);

            int currentRow = startRow, currentCol = startCol;
            
            int counter = 0;
            while (!deliveryCompleted)
            {
                string command = Console.ReadLine();

                (int rowChange, int colChange) = directions[command];
                int nextRow = currentRow + rowChange, nextCol = currentCol + colChange;

                if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
                {
                    continue;
                }
                else
                {
                    if (grid[nextRow, nextCol] == 'X')
                    {
                        counter++;
                        grid[nextRow, nextCol] = '*';
                        if (counter == 3)
                        {
                            grid[currentRow, currentCol] = 'V';
                            grid[endRow, endCol] = '*';
                            break;
                        }
                    }
                    else if (grid[nextRow, nextCol] == '*')
                    {
                        grid[currentRow, currentCol] = '*';
                        currentRow = nextRow;
                        currentCol = nextCol;
                    }
                    else if(grid[nextRow, nextCol] == 'D')
                    {
                        grid[startRow, startCol] = 'V';
                        deliveryCompleted = true;
                        break;
                    }

                }
            }

            if (deliveryCompleted) Console.WriteLine("Delivery completed!");
            else Console.WriteLine("Delivery failed, too many traffic jams!");

            PrintMatrix(grid);
        }

        static (int Row, int Col) FindStartingPostion(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 'V') return (i, j);
                }
            }

            throw new InvalidOperationException("Starting position not found.");
        }

        static (int Row, int Col) FindDeliveryPoint(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'D') return (i, j);
                }
            }

            throw new InvalidOperationException("Starting position not found.");
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
