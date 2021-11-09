using System.Collections.Generic;

namespace RPG_V3.Entities
{
    public class EntitySpecies
    {
        private EntitySpecies(string speciesName, int maxHealthPoints, int maxDamagePoints)
        {
            Name = speciesName;
            MaxHealthPoints = maxHealthPoints;
            MaxDamagePoints = maxDamagePoints;
        }

        public string Name { get; }
        public int MaxHealthPoints { get; }
        public int MaxDamagePoints { get; }

        public static EntitySpecies Moose { get { return new EntitySpecies("Moose", 7000, 10000); } }
        public static EntitySpecies Ork { get { return new EntitySpecies("Ork", 700, 1000); } }
        public static EntitySpecies Elf { get { return new EntitySpecies("Elf", 400, 1500); } }
        public static EntitySpecies Dwarf { get { return new EntitySpecies("Dwarf", 800, 700); } }
        public static EntitySpecies Giant { get { return new EntitySpecies("Giant", 1800, 1700); } }
        public static EntitySpecies Hobgoblin { get { return new EntitySpecies("Hobgoblin", 200, 100); } }
        public static EntitySpecies Griffin { get { return new EntitySpecies("Griffin", 2000, 2000); } }
        public static EntitySpecies Minotaur { get { return new EntitySpecies("Minotaur", 1500, 2500); } }
        public static EntitySpecies Centaur { get { return new EntitySpecies("Centaur", 1500, 2500); } }
        public static EntitySpecies Wolf { get { return new EntitySpecies("Wolf", 1500, 2500); } }
        public static EntitySpecies Goat { get { return new EntitySpecies("Goat", 50, 25); } }
        public static EntitySpecies Snake { get { return new EntitySpecies("Snake", 150, 250); } }
        public static EntitySpecies Bear { get { return new EntitySpecies("Bear", 500, 500); } }
        public static EntitySpecies Lion { get { return new EntitySpecies("Lion", 500, 500); } }
        public static EntitySpecies Human { get { return new EntitySpecies("Human", 2000, 2000); } }

        public static List<EntitySpecies> List()
        {
            // Added extra Humans to balance out
            return new List<EntitySpecies> 
            { 
                Moose, Ork, Elf, Dwarf, Giant, Hobgoblin, Griffin, Minotaur, Centaur, Wolf, Goat, Snake, Bear, Lion, Human, Human, Human, Human 
            };
        }

        public static void PrintSpecies()
        {
            //List<EntitySpecies> list = new List<EntitySpecies>();

            //Type type = typeof(EntitySpecies);
            //PropertyInfo[] properties = type. .GetProperties();

            //foreach (PropertyInfo property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //    list.Add(property);
            //}
        }

    }
}
