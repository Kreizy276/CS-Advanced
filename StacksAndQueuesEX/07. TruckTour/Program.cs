using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new();

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(nums);
            }

            int totalPetrol = 0;
            int totalDistance = 0;
            int startPump = 0;

            while (true)
            {
                int leftOverPetrol = 0;

                foreach (var pump in pumps)
                {
                    int petrol = pump[0];
                    int distance = pump[1];

                    totalPetrol += petrol;
                    totalDistance += distance;

                    leftOverPetrol += petrol - distance;

                    if (leftOverPetrol < 0)
                    {
                        startPump++;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }

                if (totalPetrol >= totalDistance && leftOverPetrol >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(startPump);
        }
    }
}
