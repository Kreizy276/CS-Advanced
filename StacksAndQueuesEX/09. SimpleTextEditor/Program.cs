using System;
using System.Collections.Generic;
using System.Text;

namespace _09._SimpleTextEditor
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<(int, string)> operations = new Stack<(int, string)>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', 2);
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        string appendString = input[1];
                        text.Append(appendString);
                        operations.Push((1, appendString));
                        break;

                    case 2:
                        int count = int.Parse(input[1]);
                        string removedString = text.ToString(text.Length - count, count);
                        text.Remove(text.Length - count, count);
                        operations.Push((2, removedString));
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index]);
                        break;

                    case 4:
                        if (operations.Count > 0)
                        {
                            var lastOperation = operations.Pop();
                            if (lastOperation.Item1 == 1)
                            {
                                text.Remove(text.Length - lastOperation.Item2.Length, lastOperation.Item2.Length);
                            }
                            else if (lastOperation.Item1 == 2)
                            {
                                text.Append(lastOperation.Item2);
                            }
                        }
                        break;
                }
            }
        }
    }
}