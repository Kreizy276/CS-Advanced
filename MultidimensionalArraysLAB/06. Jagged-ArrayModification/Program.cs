using System;
using System.Linq;

namespace _06._Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            ReadJaggedArray(ref jaggedArray);

            string command;
            while((command = Console.ReadLine()) != "END")
            {
                string[] splitter = command.Split();
                int row = int.Parse(splitter[1]);
                int column = int.Parse(splitter[2]);
                int value = int.Parse(splitter[3]);

                if(row >= jaggedArray.Length || row < 0 || column >= jaggedArray[row].Length || column < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (splitter[0].ToLower())
                    {
                        case "add":
                            jaggedArray[row][column] += value;
                            break;
                        case "subtract":
                            jaggedArray[row][column] -= value;
                            break;
                    }
                }
            }
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        static void ReadJaggedArray(ref int[][] jaggedArray)
        {
            for(int row = 0; row < jaggedArray.Length; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = line;
            }
        }
    }
}
