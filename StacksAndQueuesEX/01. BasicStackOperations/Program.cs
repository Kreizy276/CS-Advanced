using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = parameters[0], s = parameters[1], x = parameters[2];

            Stack<int> stack = new Stack<int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i  = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for(int i = 1; i <= s; i++)
            {
                stack.Pop();
            }

            bool isFound = false;
            int minElement = int.MaxValue;
            if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while(stack.Count > 0)
                {
                    int numToCheck = stack.Pop();
                    if (numToCheck == x)
                    {
                        isFound = true;
                        break;
                    }
                    if(minElement > numToCheck)
                    {
                        minElement = numToCheck;
                    }
                }
                Console.WriteLine(isFound ? "true" : minElement);
            }
        }
    }
}
