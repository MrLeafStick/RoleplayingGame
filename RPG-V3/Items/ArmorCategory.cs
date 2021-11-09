using RPG_V3.Interfaces.Items;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class ArmorCategory : IArmorCategory
    {
        private ArmorCategory(string name) { Name = name; }

        public string Name { get; }
        public string MinDamage { get; }
        public string MaxDamage { get; }

        public static ArmorCategory Shield { get { return new ArmorCategory("shield"); } }
        public static ArmorCategory Armor { get { return new ArmorCategory("armor"); } }
        public static ArmorCategory Helmet { get { return new ArmorCategory("helmet"); } }
        public static ArmorCategory Chainmail { get { return new ArmorCategory("chainmail"); } }
        public static ArmorCategory Gloves { get { return new ArmorCategory("gloves"); } }
        public static ArmorCategory Boots { get { return new ArmorCategory("boots"); } }

        public static List<ArmorCategory> List()
        {
            return new List<ArmorCategory> { Shield, Armor, Helmet, Chainmail, Gloves, Boots };
        }
    }
}
