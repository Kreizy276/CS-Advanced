using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindEvenOrOdds;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Predicate<int>> dict = new Dictionary<string, Predicate<int>>
        {
            ["odd"] = num => num % 2 != 0,
            ["even"] = x => x % 2 == 0
        };

        int[] numRange = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int start = numRange[0], end = numRange[1];

        string command = Console.ReadLine();

        Predicate<int> condition;
        if (dict.ContainsKey(command)) condition = dict[command];
        else condition = _ => false;

        List<int> list = Filter(start, end, condition);
        Console.WriteLine(string.Join(' ', list));
    }

    static List<int> Filter(int start, int end, Predicate<int> condition)
    {
        List<int> result = new List<int>();

        for(int i = start; i <= end; i++)
        {
            if (condition(i)) result.Add(i);
        }

        return result;
    }
}
