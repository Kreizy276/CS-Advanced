using System;
using System.Collections.Generic;

namespace _03._MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int min = int.MaxValue;
            int max = int.MinValue;

            string command;
            for(int i = 1; i <= n; i++)
            {
                command = Console.ReadLine();
                string[] splitter = command.Split();
                switch (splitter[0])
                {
                    case "1":
                        int number = int.Parse(splitter[1]);
                        stack.Push(number);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        if(stack.Count == 0)
                        {
                            continue;
                        }
                        List<int> list = new();
                        while (stack.Count > 0)
                        {
                            int x = stack.Pop();
                            list.Add(x);
                            if(max < x)
                            {
                                max = x;
                            }
                        }
                        Console.WriteLine(max);
                        for(int j = list.Count - 1; j >= 0; j--)
                        {
                            stack.Push(list[j]);
                        }
                        break;
                    case "4":
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        List<int> list2 = new();
                        while (stack.Count > 0)
                        {
                            int x = stack.Pop();
                            list2.Add(x);
                            if (min > x)
                            {
                                min = x;
                            }
                        }
                        Console.WriteLine(min);
                        for (int j = list2.Count - 1; j >= 0; j--)
                        {
                            stack.Push(list2[j]);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
