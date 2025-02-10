using System;

namespace _02._KnightsOfHonor;

internal class Program
{
    static void Main(string[] args)
    {
        Action<string> printer = s => Console.WriteLine($"Sir {s}");

        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in input)
        {
            printer(word);
        }
    }
}
