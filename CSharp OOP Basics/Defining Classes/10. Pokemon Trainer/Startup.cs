namespace _10.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            var input = Console.ReadLine();

            while (input != "Tournament")
            {
                var tokens = input.Split(' ');
                var currentPokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                if (!trainers.Any(t => t.name == tokens[0]))
                {
                    var currentTrainer = new Trainer(tokens[0], new List<Pokemon>());
                    trainers.Add(currentTrainer);
                }
                var trainer = trainers.First(t => t.name == tokens[0]);
                trainer.pokemons.Add(currentPokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                var currentElement = input.Trim();

                foreach (var trainer in trainers)
                {
                    if (trainer.pokemons.Any(p => p.element == currentElement))
                    {
                        trainer.badges++;
                    }
                    else
                    {
                        trainer.pokemons.ForEach(n => n.health -= 10);
                    }
                    trainer.pokemons.RemoveAll(p => p.health <= 0);
                }
                input = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.badges))
            {
                Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count}");
            }
        }
    }
}
