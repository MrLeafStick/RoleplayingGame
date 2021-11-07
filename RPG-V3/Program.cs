using RPG_V3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG_V3
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            List<Entity> entities = new List<Entity>();

            for (int i = 0; i < 30; i++)
            {
                entities.Add(new Entity(GenerateName(), GetRandom(EntityType.List(), rnd), GetRandom(EntitySpecies.List(), rnd), GetRandom(EntityOccupation.List(), rnd)));
            }

            int combinations = EntityType.List().Count * EntitySpecies.List().Count * EntityOccupation.List().Count;

            Console.WriteLine($"Total number of combinations: {combinations}\n");

            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }

            T GetRandom<T>(List<T> list, Random random)
            {
                return list.ElementAt(rnd.Next(0, list.Count));
            }

            string GenerateName()
            {
                List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "zor", "vaar", "khon", "an", "bel", "lin" };

                var name = generator.ElementAt(rnd.Next(0, generator.Count - 1)) +
                           generator.ElementAt(rnd.Next(0, generator.Count - 1)) +
                           generator.ElementAt(rnd.Next(0, generator.Count - 1));

                name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

                return name;
            }
        }
    }
}
