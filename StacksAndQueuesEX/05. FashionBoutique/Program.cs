using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(arr);

            int sum = 0;
            int racks = 1;
            while(stack.Count > 0)
            {
                int currentCloth = stack.Pop();
                if(sum + currentCloth > capacity)
                {
                    racks++;
                    sum = 0;
                }

                sum += currentCloth;
            }
            Console.WriteLine(racks);
        }
    }
}
