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
        public static EntityType Living { get { return new EntityType("Living"); } }
    }

    public class EntityOccupation : IEntityOccupation
    {
        private EntityOccupation(string occupation) { Name = occupation; }

        public string Name { get; }
        public int SkillLevel { get; private set; }
        public void LevelUp() { SkillLevel++; }

        public static EntityOccupation Blacksmith   { get { return new EntityOccupation("Blacksmith"); } }
        public static EntityOccupation Thief        { get { return new EntityOccupation("Thief"); } }
        public static EntityOccupation Alchemist    { get { return new EntityOccupation("Alchemist"); } }
        public static EntityOccupation Wizard       { get { return new EntityOccupation("Wizard"); } }
    }

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
    }

    public class Entity : IEntity
    {
        public Entity(string name, EntitySpecies species, EntityOccupation occupation)
        {
            Name = name;
            Species = species;
            Occupation = occupation;
        }

        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }

        public override string ToString()
        {
            var entityString = $"{Name} the {Species.Name} is a {Occupation.Name}";

            var abilityString = $"{Name} has the following abilities:\n";

            return entityString;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Entity> entities = new List<Entity>();

            EntityOccupation.Alchemist.LevelUp();

            entities.Add( new Entity("Mr. Afterburner", EntitySpecies.Human, EntityOccupation.Blacksmith) );

            foreach(var entity in entities)
            {
                Console.WriteLine(entity);
            }
        }
    }
}
