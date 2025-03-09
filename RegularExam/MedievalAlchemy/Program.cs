using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        List<int> substances = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
        List<int> crystals = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

        Dictionary<string, int> potions = new Dictionary<string, int>
        {
            {"Brew of Immortality", 110},
            {"Essence of Resilience", 100},
            {"Draught of Wisdom", 90},
            {"Potion of Agility", 80},
            {"Elixir of Strength", 70}
        };

        List<string> craftedPotions = new List<string>();

        while (substances.Any() && crystals.Any() && craftedPotions.Count < 5)
        {
            int substance = substances.Last();
            int crystal = crystals.First();

            substances.RemoveAt(substances.Count - 1);
            crystals.RemoveAt(0);

            int combinedEnergy = substance + crystal;
            bool crafted = false;

            foreach (var potion in potions.Where(p => !craftedPotions.Contains(p.Key)))
            {
                if (combinedEnergy == potion.Value)
                {
                    craftedPotions.Add(potion.Key);
                    crafted = true;
                    break;
                }
            }

            if (!crafted)
            {
                crystals.Add(0);
            }

            for (int i = 0; i < crystals.Count; i++)
            {
                crystals[i] += 5;
            }
        }

        if (craftedPotions.Count == 5)
        {
            Console.WriteLine("Success! The alchemist has forged all potions!");
        }
        else
        {
            Console.WriteLine("The alchemist failed to complete his quest.");
        }

        if (craftedPotions.Any())
        {
            Console.WriteLine("Crafted potions: " + string.Join(", ", craftedPotions));
        }

        if (substances.Any())
        {
            Console.WriteLine("Substances: " + string.Join(", ", substances));
        }

        if (crystals.Any())
        {
            Console.WriteLine("Crystals: " + string.Join(", ", crystals));
        }
    }
}
