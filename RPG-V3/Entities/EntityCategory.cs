using System.Collections.Generic;

namespace RPG_V3.Entities
{
    public class EntityCategory
    {
        private EntityCategory(string category) { Name = category; }
        public string Name { get; }

        public static EntityCategory Ghost { get { return new EntityCategory("Ghost"); } }
        public static EntityCategory Were { get { return new EntityCategory("Were"); } }
        public static EntityCategory Clockwork { get { return new EntityCategory("Clockwork"); } }
        public static EntityCategory Undead { get { return new EntityCategory("Undead"); } }
        public static EntityCategory Zombie { get { return new EntityCategory("Zombie"); } }
        public static EntityCategory Skeleton { get { return new EntityCategory("Skeleton"); } }
        public static EntityCategory Magical { get { return new EntityCategory("Magical"); } }
        public static EntityCategory Vampire { get { return new EntityCategory("Vampire"); } }
        public static EntityCategory Mummy { get { return new EntityCategory("Mummy"); } }
        public static EntityCategory Living { get { return new EntityCategory("Living"); } }

        public static List<EntityCategory> List()
        {
            // Added more "Living" to balance out 
            return new List<EntityCategory> 
            { 
                Ghost, Were, Clockwork, Undead, Zombie, Skeleton, Magical, Vampire, Mummy, Living, Living, Living, Living 
            };
        }
    }
}
