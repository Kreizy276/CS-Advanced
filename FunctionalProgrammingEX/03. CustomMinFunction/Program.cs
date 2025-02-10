using System;
using System.Linq;

namespace _03._CustomMinFunction;

internal class Program
{
    static void Main(string[] args)
    {
        Func<string, int> parse = x => int.Parse(x);

        int[] num = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(parse).ToArray();

        int min = Aggregate(num, (x, min) => x < min ? x : min, int.MaxValue);
        Console.WriteLine(min);
    }

    static int Aggregate(int[] numbers, Func<int, int, int> func, int initial)
    {
        int aggregate = initial;
        foreach(int number in numbers)
        {
            aggregate = func(number, aggregate);
        }

        return aggregate;
    }
}
