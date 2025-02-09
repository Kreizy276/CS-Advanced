using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _03._CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upperCaseChecker = n => char.IsUpper(n[0]);

            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(upperCaseChecker).ToArray();

            foreach(string word in line)
            {
                Console.WriteLine(word);
            }
        }
    }
}
