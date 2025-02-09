using System;
using System.Linq;

namespace demo;

internal class Program
{
    static void Main(string[] args)
    {
        // 1. length of a string using func
        /*string input = Console.ReadLine();

        Func<string, int> lengthOfString = s => s.Length;

        Console.WriteLine(lengthOfString(input));*/

        // 2. taking two numbers and return their difference
        /*int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Func<int, int, int> difference = (x, y) => x - y;

        Console.WriteLine(difference(n1, n2));*/

        // 3.
        /*Random random = new Random();

        Func<int, int> randomNum = x => random.Next(x);

        Console.WriteLine(randomNum(69420));*/

        string[] greetings = new string[] { "Hello, world!", "Good day, traveler!", "Stay awesome, legend! 🚀" };

        Random random = new Random();

        Func<string[], string> randomGreeting = arr => arr[random.Next(greetings.Length)];

        Console.WriteLine(randomGreeting(greetings));
    }
}
