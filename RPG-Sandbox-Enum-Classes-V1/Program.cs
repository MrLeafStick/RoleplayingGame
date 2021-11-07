using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RPG_Sandbox_Enum_Classes_V1
{
    public class EntityOccupation
    {
        private EntityOccupation(string occupation) { Name = occupation; }

        public string Name { get; }
        public string SkillLevel { get; set; }

        public static EntityOccupation Blacksmith   { get { return new EntityOccupation("Blacksmith"); } }
        public static EntityOccupation Thief        { get { return new EntityOccupation("Thief"); } }
        public static EntityOccupation Alchemist    { get { return new EntityOccupation("Alchemist"); } }
    }

    public class EntitySpecies
    {
        private EntitySpecies(string species) { Name = species; }

        public string Name { get; }
        public int MaxHealthPoints { get; }
        public int MaxDamagePoints { get; }

        public static EntitySpecies Human       { get { return new EntitySpecies("Human"); } }
        public static EntitySpecies Ork         { get { return new EntitySpecies("Ork"); } }
        public static EntitySpecies Elf         { get { return new EntitySpecies("Elf"); } }
    }

    public class Entity
    {
        public Entity(EntitySpecies species, EntityOccupation occupation)
        {
            Species = species;
            Occupation = occupation;
        }

        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; set; }

        public int GoldOwned { get; set; }
    }

    class Program
    {

        static void Main()
        {
            var Hero = new Entity(EntitySpecies.Human, EntityOccupation.Blacksmith);

            var gold = Hero.Occupation.Name;

            Console.WriteLine(gold);
        }
    }
}
