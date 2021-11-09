using RPG_V3.Interfaces;

namespace RPG_V3.Items
{
    class Armor : Item, IArmor
    {
        /*
        public static Armor WoodenShield { get { return new Armor("Wooden Shield", 1.0, 3.0, 10.0, 1.0); } }
        */
        public Armor(ArmorCategory category, Material material, double value, double weight, double maxArmorPoints, double minArmorPoints)
            : base("", value, weight)
        {
            Category = category;
            Material = material;

            var name = Material.Name + Category.Name;
            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            Name = name;
            MaxArmorPoints = maxArmorPoints;
            MinArmorPoints = minArmorPoints;
        }

        public Armor(Armor armor) : base(armor)
        {
            Category = armor.Category;
            Material = armor.Material;
            MaxArmorPoints = armor.MaxArmorPoints;
            MinArmorPoints = armor.MinArmorPoints;
        }

        /*
        public static List<Armor> List()
        {
            return new List<Armor> { WoodenShield, LeatherShield, BronzeShield, IronShield, SteelShield };
        }
        */

        public ArmorCategory Category { get; }
        public Material Material { get; }
        public double MaxArmorPoints { get; }
        public double MinArmorPoints { get; }
    }
}
