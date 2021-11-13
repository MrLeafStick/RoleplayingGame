using RPG_V3.Interfaces.Items;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class ArmorCategory : IArmorCategory
    {
        private ArmorCategory(string name) 
        { 
            Name = name; 
        }

        public string Name { get; }

        public static ArmorCategory Shield { get { return new ArmorCategory("shield"); } }
        public static ArmorCategory Breastplate { get { return new ArmorCategory("breastplate"); } }
        public static ArmorCategory Helmet { get { return new ArmorCategory("helmet"); } }
        public static ArmorCategory Chainmail { get { return new ArmorCategory("chainmail"); } }
        public static ArmorCategory Gloves { get { return new ArmorCategory("gloves"); } }
        public static ArmorCategory Boots { get { return new ArmorCategory("boots"); } }
        public static ArmorCategory None { get { return new ArmorCategory("none"); } }

        public static List<ArmorCategory> List()
        {
            return new List<ArmorCategory> { Shield, Breastplate, Helmet, Chainmail, Gloves, Boots };
        }
    }
}
