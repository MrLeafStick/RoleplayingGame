using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Entities
{
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
            // Added more "Living" to balance out 
            return new List<EntityType> { Ghost, Were, Clockwork, Undead, Zombie, Skeleton, Magical, Living, Living, Living, Living };
        }
    }
}
