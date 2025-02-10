using System.Collections.Generic;

namespace _01._UniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> uniqueNames = new();

            int countOfNames = int.Parse(Console.ReadLine()); 

            for(int i = 1; i <= countOfNames; i++)
            {
                string uniqueName = Console.ReadLine();
                if (!uniqueNames.ContainsKey(uniqueName))
                {
                    uniqueNames.Add(uniqueName, i);
                }
                else
                {
                    continue;
                }
            }

            foreach(string uniqueName in uniqueNames.Keys)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}
