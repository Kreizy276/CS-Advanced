namespace _02._DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];

            char[,] field = new char[rows, cols];

            Dictionary<string, (int, int)> directions = new()
            {
                ["up"] = (-1, 0),
                ["right"] = (0, 1),
                ["down"] = (1, 0),
                ["left"] = (0, -1)
            };

            // read the matrix
            for(int i = 0; i < rows; i++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for(int j = 0; j < cols; j++)
                {
                    field[i, j] = line[j];
                }
            }

            (int startRow, int startCol) = FindStartiPosition(field);
            int currentRow = startRow, currentCol = startCol;

            bool addressReached = false, outOfBounds = false;

            while(!addressReached && !outOfBounds)
            {
                string command = Console.ReadLine();

                (int rowChange, int colChange) = directions[command];
                int nextRow = currentRow + rowChange, nextCol = currentCol + colChange;


                if(nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
                {
                    outOfBounds = true;
                }
                else
                {
                    if (field[nextRow, nextCol] == '-') field[nextRow, nextCol] = '.';
                    else if (field[nextRow, nextCol] == 'P')
                    {
                        Console.WriteLine("Pizza collected. 10 minutes for delivery.");
                        field[nextRow, nextCol] = 'R';
                    }
                    else if (field[nextRow, nextCol] == 'A')
                    {
                        field[nextRow, nextCol] = 'P';
                        addressReached = true;
                    }
                    if (field[nextRow, nextCol] != '*')
                    {
                        currentRow = nextRow;
                        currentCol = nextCol;
                    }
                }
            }
            if(addressReached) Console.WriteLine("Pizza is delivered on time! Next order...");
            if (outOfBounds)
            {
                field[startRow, startCol] = ' ';
                Console.WriteLine("The delivery is late. Order is canceled");
            }

            PrintMatrix(field);
        }

        static (int Row, int Col) FindStartiPosition(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 'B') return (i, j);
                }
            }

            throw new InvalidOperationException("Starting position not found.");
        }
        static void PrintMatrix(char[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
