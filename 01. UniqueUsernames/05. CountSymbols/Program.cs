namespace _05._CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charCounts = new();

            string input = Console.ReadLine();

            foreach(char c in input)
            {
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 0;
                }
                charCounts[c]++;
            }

            foreach (var kvp in charCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
