using System;
using System.Linq;

namespace _04._AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach(double number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
