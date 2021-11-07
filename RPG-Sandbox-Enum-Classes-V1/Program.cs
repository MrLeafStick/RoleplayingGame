using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RPG_Sandbox_Enum_Classes_V1
{
    public interface IItem
    {
        public string Name { get; }
        public int Value { get; }
    }

    public interface IWeapon : IItem
    {
        public int MaxDamagePoints { get; }
    }

    public interface IArmor : IItem
    {
        public int MaxArmorPoints { get; }
    }

    public interface IEntity
    {
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }
    }

    public interface IEntityOccupation
    {
        public string Name { get; }
        public int SkillLevel { get; }
        public void LevelUp();
    }

    public class EntityType
    {
        private EntityType(string type) { Name = type; }
        public string Name { get; }

        public static EntityType Ghost { get { return new EntityType("Ghost"); } }
        public static EntityType Were { get { return new EntityType("Were"); } }
        public static EntityType Clockwork { get { return new EntityType("Clockwork"); } }
        public static EntityType Undead { get { return new EntityType("Undead"); } }
        public static EntityType Zombie { get { return new EntityType("Zombie"); } }
        public static EntityType Skeleton { get { return new EntityType("Skeleton"); } }
        public static EntityType Magical { get { return new EntityType("Magical"); } }
        public static EntityType Living { get { return new EntityType("Living"); } }

        public static List<EntityType> List()
        {
            return new List<EntityType> { Ghost, Were, Clockwork, Undead, Zombie, Skeleton, Magical, Living };
        }
    }

    //Peasant,
    //Miller,
    //Shopkeeper,
    //Innkeeper,
    //Sailor,
    //Marauder,
    //Torturer,
    //King,
    //Merchant,
    //Blacksmith,
    //Thief,
    //Robber,
    //Wizard,
    //Warrior,
    //Knight,
    //Archer,
    //Enchanterer,
    //Mage,
    //Necromancer,
    //Alchemist,
    //Warlock,
    //Priest,
    //Monk,
    //Beast,

    public class EntityOccupation : IEntityOccupation
    {
        private EntityOccupation(string occupation) { Name = occupation; }

        public string Name { get; }
        public int SkillLevel { get; private set; }
        public void LevelUp() { SkillLevel++; }

        public static EntityOccupation Peasant   { get { return new EntityOccupation("Peasant"); } }
        public static EntityOccupation Blacksmith   { get { return new EntityOccupation("Blacksmith"); } }
        public static EntityOccupation InnKeeper   { get { return new EntityOccupation("InnKeeper"); } }
        public static EntityOccupation Thief        { get { return new EntityOccupation("Thief"); } }
        public static EntityOccupation Alchemist    { get { return new EntityOccupation("Alchemist"); } }
        public static EntityOccupation Wizard       { get { return new EntityOccupation("Wizard"); } }
        public static EntityOccupation Torturer       { get { return new EntityOccupation("Torturer"); } }
        public static EntityOccupation Warlock       { get { return new EntityOccupation("Warlock"); } }
        public static EntityOccupation Necromancer       { get { return new EntityOccupation("Necromancer"); } }

        public static List<EntityOccupation> List()
        {
            return new List<EntityOccupation> { Peasant, Blacksmith, InnKeeper, Thief, Alchemist, Wizard, Torturer, Warlock, Necromancer };
        }

    }

    //Human,
    //Elf,
    //Sprite,
    //Ork,
    //Troll,
    //Dwarf,
    //Giant,
    //Hobgoblin,
    //Gargoyle,
    //Griffin,
    //Centaur,
    //Minotaur,
    //Dragon,
    //Unicorn,
    //Golem,
    //Wolf,
    //Goat,
    //Bear,
    //Snake,
    //Owl,
    //Lion,
    //Fox,
    //Eagle,
    //Orca,
    //Squid,
    //Whale,
    //Sealion

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

        public static EntitySpecies Human       { get { return new EntitySpecies("Human", 500, 500); } }
        public static EntitySpecies Ork         { get { return new EntitySpecies("Ork", 700, 1000); } }
        public static EntitySpecies Elf         { get { return new EntitySpecies("Elf", 400, 1500); } }
        public static EntitySpecies Dwarf       { get { return new EntitySpecies("Dwarf", 800, 700); } }
        public static EntitySpecies Hobgoblin   { get { return new EntitySpecies("Hobgoblin", 200, 100); } }
        public static EntitySpecies Griffin     { get { return new EntitySpecies("Griffin", 2000, 2000); } }
        public static EntitySpecies Minotaur    { get { return new EntitySpecies("Minotaur", 1500, 2500); } }
        public static EntitySpecies Wolf    { get { return new EntitySpecies("Wolf", 1500, 2500); } }
        public static EntitySpecies Goat    { get { return new EntitySpecies("Goat", 50, 25); } }
        public static EntitySpecies Snake    { get { return new EntitySpecies("Snake", 150, 250); } }
        public static EntitySpecies Bear    { get { return new EntitySpecies("Bear", 500, 500); } }

        public static List<EntitySpecies> List()
        {
            return new List<EntitySpecies> { Human, Ork, Elf, Dwarf, Hobgoblin, Griffin, Minotaur, Wolf, Goat, Snake, Bear };
        }
    }

    public class Entity : IEntity
    {
        public Entity(string name, EntityType type, EntitySpecies species, EntityOccupation occupation)
        {
            Name = name;
            Type = type;
            Species = species;
            Occupation = occupation;
        }

        public EntityType Type { get; }
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }

        public override string ToString()
        {
            var entityString = $"{Name} the {Type.Name} {Species.Name} is a {Occupation.Name}";

            var abilityString = $"{Name} has the following abilities:\n";

            return entityString;
        }
    }

    class Program
    {
        static void Main()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            List<Entity> entities = new List<Entity>();

            for (int i = 0; i < 30; i++)
            {
                entities.Add(new Entity($"Mr. Afterburner {i}", GetRandom(EntityType.List(), rnd), GetRandom(EntitySpecies.List(), rnd), GetRandom(EntityOccupation.List(), rnd)));
            }

            int combinations = EntityType.List().Count * EntitySpecies.List().Count * EntityOccupation.List().Count;

            Console.WriteLine($"Total number of combinations: {combinations}\n");

            foreach(var entity in entities)
            {
                Console.WriteLine(entity);
            }

            T GetRandom<T>(List<T> list, Random random)
            {
                return list.ElementAt(rnd.Next(0, list.Count));
            }
        }
    }
}
