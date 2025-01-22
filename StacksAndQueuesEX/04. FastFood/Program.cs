using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            int max = queue.Max();

            bool ordersComplete = true;
            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity < currentOrder)
                {
                    ordersComplete = false;
                    break;
                }

                queue.Dequeue();
                foodQuantity -= currentOrder;
            }

            Console.WriteLine(max);

            if (ordersComplete)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}