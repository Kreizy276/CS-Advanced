namespace _04._EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!numberCounts.ContainsKey(currentNum))
                {
                    numberCounts[currentNum] = 0;
                }
                numberCounts[currentNum]++;
            }

            foreach (var kvp in numberCounts)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                    return;
                }
            }
        }
    }
}
