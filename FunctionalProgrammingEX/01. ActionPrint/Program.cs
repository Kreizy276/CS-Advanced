using System;

namespace _01._ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = s => Console.WriteLine(s);

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach(string word in input)
            {
                printer(word);
            }
        }
    }
}
