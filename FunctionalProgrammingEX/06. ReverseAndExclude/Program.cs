using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ReverseAndExclude;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int n = int.Parse(Console.ReadLine());

        List<int> result = Transform(n, numbers, (x, n) => x % n != 0);
        Console.WriteLine(string.Join(' ', result));
    }

    static List<int> Transform(int n, int[] numbers, Func<int, int, bool> func)
    {
        List<int> result = new List<int>();

        for(int i = numbers.Length - 1; i >= 0; i--)
        {
            if (func(numbers[i], n))
            {
                result.Add(numbers[i]);
            }
        }

        return result;
    }
}
