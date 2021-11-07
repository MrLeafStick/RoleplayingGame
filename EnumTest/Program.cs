using System;
using System.Collections.Generic;

namespace EnumTest
{
    public static class RNG
    {
        private static Random _generator = new Random(Guid.NewGuid().GetHashCode());

        public static int RandomInt(int minVal, int maxVal)
        {
            return _generator.Next(minVal, maxVal + 1);
        }

        public static int RandomPercent()
        {
            return _generator.Next(0, 100 + 1);
        }

        public static double RandomDouble(double minVal, double maxVal)
        {
            return _generator.NextDouble() * (maxVal - minVal) + minVal;
        }

        public static bool CoinFlip()
        {
            return RandomPercent() < 50;
        }
    }

    class Program
    {

        // Enums
        public enum Item
        {
            Ru
        }

        public enum AbilityName
        {
            Bite,
            Sting,
            Kick,
            FistBlow,
        }

        public enum AbilityType
        {
            Melee,
            Ranged,

        }

        public enum EntitySpecies
        {
            Human,
            Elf,
            Sprite,
            Ork,
            Troll,
            Dwarf,
            Giant,
            Hobgoblin,
            Gargoyle,
            Griffin,
            Centaur,
            Minotaur,
            Dragon,
            Unicorn,
            Golem,
            Wolf,
            Goat,
            Bear,
            Snake,
            Owl,
            Lion,
            Fox,
            Eagle,
            Orca,
            Squid,
            Whale,
            Sealion
        }

        public enum EntityType
        {
            Ghost,
            Were,
            Mechanical,
            Undead,
            Zombie,
            Skeleton,
            Magical,
            Living,
        }

        public enum EntityOccupation
        {
            Peasant,
            Miller,
            Shopkeeper,
            Innkeeper,
            Sailor,
            Marauder,
            Torturer,
            King,
            Merchant,
            Blacksmith,
            Thief,
            Robber,
            Wizard,
            Warrior,
            Knight,
            Archer,
            Enchanterer,
            Mage,
            Necromancer,
            Alchemist,
            Warlock,
            Priest,
            Monk,
            Beast,
        }

        // Classes
        public class Ability
        {
            public Ability(AbilityName name, int skillLevel)
            {
                Name = name;
                SkillLevel = skillLevel;
            }

            public AbilityName Name { get; }
            public int SkillLevel { get; }
        }

        public class Entity
        {
            public Entity(string name, EntityType type, EntitySpecies species, EntityOccupation occupation, int healthPoints)
            {
                Name = name;
                EntityType = type;
                EntitySpecies = species;
                EntityOccupation = occupation;
                MaxHealthPoints = healthPoints;

                Abilities = new List<Ability>();
            }

            public string Name { get; }
            public EntityType EntityType { get; }
            public EntitySpecies EntitySpecies { get; }
            public EntityOccupation EntityOccupation { get; set; }
            public int MaxHealthPoints { get; }
            public List<Ability> Abilities { get; }
            public List<Item> Items { get; }

            public override string ToString()
            {
                var entityString = $"{Name} the {EntityType} {EntitySpecies} is a {EntityOccupation} and has {MaxHealthPoints} health points.";

                var abilityString = $"{Name} has the following abilities:\n";

                foreach (var ability in Abilities)
                {
                    abilityString += ability.ToString();
                }

                return entityString;
            }
        }

        static void Main()
        {
            List<Entity> entities = new List<Entity>();

            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 30; i++)
            {
                string name = GenerateName();
                EntityType entity = EnumRndVal<EntityType>();
                EntitySpecies species = EnumRndVal<EntitySpecies>();
                EntityOccupation occupation = EnumRndVal<EntityOccupation>();

                entities.Add(new Entity(name, entity, species, occupation, rnd.Next(1, 1000)));
            }

            int totalCombinations = EnumCount<EntityType>() * EnumCount<EntitySpecies>() * EnumCount<EntityOccupation>();

            Console.WriteLine($"Number of combinations: {totalCombinations}");

            Console.WriteLine("\n");

            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }

        }

        static int EnumCount<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return v.Length;
        }

        static T EnumRndVal<T>()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(rnd.Next(v.Length));
        }

        static string GenerateName()
        {
            List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "zor", "vaar", "khon", "an", "bel", "lin" };

            var name = generator[RNG.RandomInt(0, generator.Count - 1)] +
                       generator[RNG.RandomInt(0, generator.Count - 1)] +
                       generator[RNG.RandomInt(0, generator.Count - 1)];

            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }
    }
}
