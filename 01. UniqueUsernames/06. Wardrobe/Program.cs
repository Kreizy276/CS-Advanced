namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(" -> ");
                string color = parts[0];
                string[] clothes = parts[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (string item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] searchQuery = Console.ReadLine().Split();
            string searchColor = searchQuery[0];
            string searchClothing = searchQuery[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var item in kvp.Value)
                {
                    string found = (kvp.Key == searchColor && item.Key == searchClothing) ? " (found!)" : "";
                    Console.WriteLine($"* {item.Key} - {item.Value}{found}");
                }
            }
        }
    }
}
