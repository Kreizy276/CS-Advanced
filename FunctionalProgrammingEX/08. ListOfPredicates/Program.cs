using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace _08._ListOfPredicates;

internal class Program
{
    static void Main(string[] args)
    {
        int range = int.Parse(Console.ReadLine());

        int[] divisors = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        List<int> validNumbers = ValidNumbers(divisors, range, x => divisors.All(div => x % div == 0));
        Console.WriteLine(string.Join(' ', validNumbers));
    }

    static List<int> ValidNumbers(int[] divisors, int range, Func<int, bool> conditions)
    {
        List<int> result = new List<int>();

        int end = range;
        for(int i = 1; i <= range; i++)
        {
            if(conditions(i)) result.Add(i);
        }

        return result;
    }

    /*static List<int> ValidNumbers(int range, int[] divisors, Predicate<int> condition)
    {
        List<int> result = new();

        int end = range;
        for(int i = 1; i <= end; i++)
        {
            if(condition(i)) result.Add(i);
        }

        return result;
    }*/
}
