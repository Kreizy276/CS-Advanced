using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = parameters[0], s = parameters[1], x = parameters[2];

            Queue<int> queue = new Queue<int>();

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0;  i < arr.Length; i++)
            {
                queue.Enqueue(arr[i]);
            }

            for(int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            bool isFound = false;
            int min = int.MaxValue;
            if(queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while(queue.Count > 0)
                {
                    int numCheck = queue.Dequeue();

                    if (numCheck == x)
                    {
                        isFound = true;
                        break;
                    }

                    if (min > numCheck)
                    {
                        min = numCheck;
                    }
                }
                Console.WriteLine(isFound ? "true" : min);
            }
        }
    }
}
