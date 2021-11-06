using System;
using System.Collections.Generic;
using System.Linq;

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
            Living,
            Breathing,
            Alive,
            Regular,
            Zombie,
            Skeleton,
            Magical,
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
            Highwayman,
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


        // Descriptors
        public class AbilityDescriptor
        {
            public AbilityDescriptor(AbilityName name)
            {
                Name = name;
            }

            public AbilityName Name { get; set; }

        }

        public class EntityDescriptor
        {
            public EntityDescriptor(EntitySpecies species, EntityOccupation occupation, int maxHealthPoints)
            {
                EntitySpecies = species;
                EntityOccupation = occupation;
                MaxHealthPoints = maxHealthPoints;

                AllowedAbilities = new List<AbilityName>();
            }

            public EntitySpecies EntitySpecies { get; set; }
            public EntityOccupation EntityOccupation { get; set; }
            public int MaxHealthPoints { get; set; }

            public List<AbilityName> AllowedAbilities { get; set; }
        }

        // Classes
        public class Ability
        {
            public Ability(AbilityDescriptor abilityDescriptor)
            {
                Name = abilityDescriptor.Name;
            }

            public AbilityName Name { get; }
            public int SkillLevel { get; }
        }

        public class Item
        {

        }

        public class Entity
        {
            public Entity(string name, EntityDescriptor entityDescriptor)
            {
                Name = name;
                EntitySpecies = entityDescriptor.EntitySpecies;
                EntityOccupation = entityDescriptor.EntityOccupation;
                MaxHealthPoints = entityDescriptor.MaxHealthPoints;

                Abilities = new List<Ability>();
            }

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
                var entityString =  $"{Name} the {EntityType} {EntitySpecies} is a {EntityOccupation} and has {MaxHealthPoints} health points.";

                var abilityString = $"{Name} has the following abilities:\n";

                foreach(var ability in Abilities)
                {
                    abilityString += ability.ToString();
                }

                return entityString;
            }
        }

        static void Main()
        {
            List<AbilityDescriptor> abilityDescriptors = new List<AbilityDescriptor>();
            List<EntityDescriptor> entityDescriptors = new List<EntityDescriptor>();

            List<Item> items = new List<Item>();
            List<Ability> abilities = new List<Ability>();
            List<Entity> entities = new List<Entity>();

            /*
            // Descriptors
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Human, EntityOccupation.Thief, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Elven, EntityOccupation.Marauder, 500 ));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Ork, EntityOccupation.Knight, 700));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Ork, EntityOccupation.Warrior, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Troll, EntityOccupation.Archer, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Dwarf, EntityOccupation.Knight, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Dragon, EntityOccupation.Warlock, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Unicorn, EntityOccupation.Necromancer, 500));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Wolf, EntityOccupation.Beast, 100));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Goat, EntityOccupation.Wizard, 100));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Bear, EntityOccupation.Beast, 100));
            entityDescriptors.Add(new EntityDescriptor(EntitySpecies.Snake, EntityOccupation.Beast, 100));

            // Default descriptors
            EntityDescriptor defaultEntityDescriptor = new EntityDescriptor(EntitySpecies.Human, EntityOccupation.Blacksmith, 4200);
            
            // Entities
            entities.Add(new Entity("Loktar", entityDescriptors.Where(e => e.EntitySpecies == EntitySpecies.Ork).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Fenris", entityDescriptors.Where(e => e.EntitySpecies == EntitySpecies.Wolf).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Inruel", entityDescriptors.Where(e => e.EntityOccupation == EntityOccupation.Warrior).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.EntitySpecies == EntitySpecies.Ork && e.EntityOccupation == EntityOccupation.Warrior).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.EntityOccupation == EntityOccupation.Archer).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.EntityOccupation == EntityOccupation.Marauder).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.EntityOccupation == EntityOccupation.Necromancer).DefaultIfEmpty(defaultEntityDescriptor).First()));

            entities.Add(new Entity("Garglebloth", EntityType.Undead, EntitySpecies.Ork, EntityOccupation.Marauder, 350));
            entities.Add(new Entity("Ymritol", EntityType.Were, EntitySpecies.Unicorn, EntityOccupation.Miller, 35000));
            entities.Add(new Entity("Zooldestir", EntityType.Skeleton, EntitySpecies.Dwarf, EntityOccupation.Peasant, 30));
            entities.Add(new Entity("Random", EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), 30));
            entities.Add(new Entity("Random", EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), 30));
            entities.Add(new Entity("Random", EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), 30));
            entities.Add(new Entity("Random", EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), 30));
            entities.Add(new Entity("Random", EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), 30));
            */
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 30; i++)
            {
                entities.Add(new Entity(GenerateName(), EnumRndVal<EntityType>(), EnumRndVal<EntitySpecies>(), EnumRndVal<EntityOccupation>(), rnd.Next(1, 1000)));
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
