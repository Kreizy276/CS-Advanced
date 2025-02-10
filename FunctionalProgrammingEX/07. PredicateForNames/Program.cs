using System;
using System.Collections.Generic;

namespace _07._PredicateForNames;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Iterate(names, x => x.Length <= n, x => Console.WriteLine(x));
        
        /*List<string> validNames = Filter(names, n, (w, length) => w.Length <= length);
        foreach(string name in validNames)
        {
            Console.WriteLine(name);
        }*/
    }

    static void Iterate(string[] array, Predicate<string> condition, Action<string> action)
    {
        foreach(string name in array)
        {
            if(condition(name)) action(name);
        }
    }

    /*static List<string> Filter(string[] names, int length, Func<string, int, bool> func)
    {
        List<string> result = new List<string>();

        foreach (string name in names)
        {
            if(func(name, length))
            {
                result.Add(name);
            }
        }

        return result;
    }*/
}
