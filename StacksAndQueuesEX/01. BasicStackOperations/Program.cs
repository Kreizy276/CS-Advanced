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
            // assign the numbers from the array 'numbers' to the stack
            for(int i  = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            // take away values from the stack as many as 's' variable value
            for(int i = 1; i <= s; i++)
            {
                stack.Pop();
            }

            bool isFound = false;
            int minElement = int.MaxValue;
            //if the stack has no elements we directly print 0, else we pop elements check if it is in the stack with 'x' variable and if the 'x' number does not exist in the stack then we check for the smallest value and print it
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
