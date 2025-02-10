namespace _02._SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = lengths[0];
            int m = lengths[1];

            HashSet<int> firstSet = new HashSet<int>();
            List<int> firstOrder = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!firstSet.Contains(num))
                {
                    firstSet.Add(num);
                    firstOrder.Add(num);
                }
            }

            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            List<int> commonElements = firstOrder.Where(num => secondSet.Contains(num)).ToList();

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
