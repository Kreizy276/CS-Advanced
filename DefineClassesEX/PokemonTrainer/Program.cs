namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Trainer[] trainers = ReadData();
            ProcessData(trainers);

            foreach(Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        static Trainer[] ReadData()
        {
            Dictionary<string, Trainer> trainerNames = new Dictionary<string, Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer;
                if (!trainerNames.ContainsKey(trainerName))
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainerNames.Add(trainerName, trainer);
                }
                else
                {
                    trainerNames[trainerName].Pokemons.Add(pokemon);
                }
            }

            return trainerNames.Values.ToArray();
        }
        static void ProcessData(Trainer[] trainers)
        {
            string action;
            while ((action = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == action))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = trainer.Pokemons.Count - 1; i >= 0; i--)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                            }
                        }
                    }
                }
            }
        }
    }
}