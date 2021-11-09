using RPG_V3.Helpers;
using RPG_V3.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RPG_V3.Entities
{
    public class EntityOccupation : Enumeration, IEntityOccupation
    {
        private EntityOccupation(string name) 
        { 
            Name = name; 
        }

        public string Name { get; }
        public int SkillLevel { get; private set; }
        public void LevelUp() { SkillLevel++; }

        public static EntityOccupation Peasant { get { return new EntityOccupation("a Peasant"); } }
        public static EntityOccupation Miller { get { return new EntityOccupation("a Miller"); } }
        public static EntityOccupation Blacksmith { get { return new EntityOccupation("a Blacksmith"); } }
        public static EntityOccupation InnKeeper { get { return new EntityOccupation("an InnKeeper"); } }
        public static EntityOccupation Thief { get { return new EntityOccupation("a Thief"); } }
        public static EntityOccupation Robber { get { return new EntityOccupation("a Robber"); } }
        public static EntityOccupation Rogue { get { return new EntityOccupation("a Rogue"); } }
        public static EntityOccupation Marauder { get { return new EntityOccupation("a Marauder"); } }
        public static EntityOccupation Alchemist { get { return new EntityOccupation("an Alchemist"); } }
        public static EntityOccupation Wizard { get { return new EntityOccupation("a Wizard"); } }
        public static EntityOccupation Enchanterer { get { return new EntityOccupation("an Enchanterer"); } }
        public static EntityOccupation Mage { get { return new EntityOccupation("a Mage"); } }
        public static EntityOccupation Torturer { get { return new EntityOccupation("a Torturer"); } }
        public static EntityOccupation Warlock { get { return new EntityOccupation("a Warlock"); } }
        public static EntityOccupation Necromancer { get { return new EntityOccupation("a Necromancer"); } }
        public static EntityOccupation Warrior { get { return new EntityOccupation("a Warrior"); } }
        public static EntityOccupation Knight { get { return new EntityOccupation("a Knight"); } }
        public static EntityOccupation Mercenary { get { return new EntityOccupation("a Mercenary"); } }
        public static EntityOccupation Assasin { get { return new EntityOccupation("an Assasin"); } }
        public static EntityOccupation Archer { get { return new EntityOccupation("an Archer"); } }
        public static EntityOccupation Priest { get { return new EntityOccupation("a Priest"); } }
        public static EntityOccupation Druid { get { return new EntityOccupation("a Druid"); } }

        public static List<EntityOccupation> List()
        {
            return new List<EntityOccupation> 
            { 
                Peasant, Miller, Blacksmith, InnKeeper, Thief, Robber, Rogue, Marauder, Alchemist, Wizard, Enchanterer, Mage, 
                Torturer, Warlock, Necromancer, Warrior, Knight, Mercenary, Assasin, Archer, Priest, Druid
            };
        }
    }
}
