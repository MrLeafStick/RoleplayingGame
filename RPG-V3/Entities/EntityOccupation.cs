using RPG_V3.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Entities
{
    public class EntityOccupation : IEntityOccupation
    {
        private EntityOccupation(string occupation) { Name = occupation; }

        public string Name { get; }
        public int SkillLevel { get; private set; }
        public void LevelUp() { SkillLevel++; }

        public static EntityOccupation Peasant { get { return new EntityOccupation("a Peasant"); } }
        public static EntityOccupation Blacksmith { get { return new EntityOccupation("a Blacksmith"); } }
        public static EntityOccupation InnKeeper { get { return new EntityOccupation("an InnKeeper"); } }
        public static EntityOccupation Thief { get { return new EntityOccupation("a Thief"); } }
        public static EntityOccupation Robber { get { return new EntityOccupation("a Robber"); } }
        public static EntityOccupation Alchemist { get { return new EntityOccupation("an Alchemist"); } }
        public static EntityOccupation Wizard { get { return new EntityOccupation("a Wizard"); } }
        public static EntityOccupation Torturer { get { return new EntityOccupation("a Torturer"); } }
        public static EntityOccupation Warlock { get { return new EntityOccupation("a Warlock"); } }
        public static EntityOccupation Necromancer { get { return new EntityOccupation("a Necromancer"); } }
        public static EntityOccupation Warrior { get { return new EntityOccupation("a Warrior"); } }
        public static EntityOccupation Archer { get { return new EntityOccupation("an Archer"); } }
        public static EntityOccupation Priest { get { return new EntityOccupation("a Priest"); } }

        public static List<EntityOccupation> List()
        {
            return new List<EntityOccupation> { Peasant, Blacksmith, InnKeeper, Thief, Robber, Alchemist, Wizard, Torturer, Warlock, Necromancer, Warrior, Archer, Priest };
        }

    }
}
