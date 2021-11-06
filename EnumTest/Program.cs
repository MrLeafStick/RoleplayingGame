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

        public enum Gender
        {
            Female,
            Male,
            Genderless,
            Other
        }


        public enum Species
        {
            Human,
            Elven,
            Ork,
            Troll,
            Dwarf,
            Hobgoblin,
            Gargoyle,
            Griffin,
            Centaur,
            Dragon,
            Unicorn,
            Wolf,
            Goat,
            Bear,
            Snake,
            Owl,
        }

        public enum Type : ushort
        {
            Ghost,
            Were,
            Mechanical,
            Undead,
            Living,
            Zombie,
            Skeleton,
            Magical,
        }

        public enum Occupation
        {
            Peasant,
            Miller,
            Shopkeeper,
            Marauder,
            Blacksmith,
            Thief,
            Wizard,
            Warrior,
            Knight,
            Archer,
            Enchanterer,
            Mage,
            Necromancer,
            Warlock,
            Priest,
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
            public EntityDescriptor(Species species, Occupation occupation, int maxHealthPoints)
            {
                Species = species;
                Occupation = occupation;
                MaxHealthPoints = maxHealthPoints;

                AllowedAbilities = new List<AbilityName>();
            }

            public Species Species { get; set; }
            public Occupation Occupation { get; set; }
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

        public class Entity
        {
            public Entity(string name, EntityDescriptor entityDescriptor)
            {
                Name = name;
                Species = entityDescriptor.Species;
                Occupation = entityDescriptor.Occupation;
                MaxHealthPoints = entityDescriptor.MaxHealthPoints;

                Abilities = new List<Ability>();
            }

            public Entity(string name, Type type, Species species, Occupation occupation, int healthPoints)
            {
                Name = name;
                Type = type;
                Species = species;
                Occupation = occupation;
                MaxHealthPoints = healthPoints;
                
                Abilities = new List<Ability>();
            }

            public string Name { get; }
            public Type Type { get; }
            public Species Species { get; }
            public Occupation Occupation { get; set; }
            public int MaxHealthPoints { get; }
            public List<Ability> Abilities { get; }

            public override string ToString()
            {
                var entityString =  $"{Name} the {Type} {Species} is a {Occupation} and has {MaxHealthPoints} health points.";

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

            List<Ability> abilities = new List<Ability>();
            List<Entity> entities = new List<Entity>();

            /*
            // Descriptors
            entityDescriptors.Add(new EntityDescriptor(Species.Human, Occupation.Thief, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Elven, Occupation.Marauder, 500 ));
            entityDescriptors.Add(new EntityDescriptor(Species.Ork, Occupation.Knight, 700));
            entityDescriptors.Add(new EntityDescriptor(Species.Ork, Occupation.Warrior, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Troll, Occupation.Archer, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Dwarf, Occupation.Knight, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Dragon, Occupation.Warlock, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Unicorn, Occupation.Necromancer, 500));
            entityDescriptors.Add(new EntityDescriptor(Species.Wolf, Occupation.Beast, 100));
            entityDescriptors.Add(new EntityDescriptor(Species.Goat, Occupation.Wizard, 100));
            entityDescriptors.Add(new EntityDescriptor(Species.Bear, Occupation.Beast, 100));
            entityDescriptors.Add(new EntityDescriptor(Species.Snake, Occupation.Beast, 100));

            // Default descriptors
            EntityDescriptor defaultEntityDescriptor = new EntityDescriptor(Species.Human, Occupation.Blacksmith, 4200);
            
            // Entities
            entities.Add(new Entity("Loktar", entityDescriptors.Where(e => e.Species == Species.Ork).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Fenris", entityDescriptors.Where(e => e.Species == Species.Wolf).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Inruel", entityDescriptors.Where(e => e.Occupation == Occupation.Warrior).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.Species == Species.Ork && e.Occupation == Occupation.Warrior).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.Occupation == Occupation.Archer).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.Occupation == Occupation.Marauder).DefaultIfEmpty(defaultEntityDescriptor).First()));
            entities.Add(new Entity("Ekhel", entityDescriptors.Where(e => e.Occupation == Occupation.Necromancer).DefaultIfEmpty(defaultEntityDescriptor).First()));

            entities.Add(new Entity("Garglebloth", Type.Undead, Species.Ork, Occupation.Marauder, 350));
            entities.Add(new Entity("Ymritol", Type.Were, Species.Unicorn, Occupation.Miller, 35000));
            entities.Add(new Entity("Zooldestir", Type.Skeleton, Species.Dwarf, Occupation.Peasant, 30));
            entities.Add(new Entity("Random", RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), 30));
            entities.Add(new Entity("Random", RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), 30));
            entities.Add(new Entity("Random", RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), 30));
            entities.Add(new Entity("Random", RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), 30));
            entities.Add(new Entity("Random", RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), 30));
            */
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 20; i++)
            {
                entities.Add(new Entity(GenerateName(), RndEnumVal<Type>(), RndEnumVal<Species>(), RndEnumVal<Occupation>(), rnd.Next(1, 1000)));
            }

            foreach(var entity in entities)
            {
                Console.WriteLine(entity);
            }

        }

        static T RndEnumVal<T>()
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
