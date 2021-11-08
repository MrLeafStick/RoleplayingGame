using RPG_V3.Interfaces;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class Armor : IArmor
    {
        /*
        public static Armor WoodenShield { get { return new Armor("Wooden Shield", 1.0, 3.0, 10.0, 1.0); } }
        public static Armor LeatherShield { get { return new Armor("Leather Shield", 2.0, 4.0, 15.0, 1.0); } }
        public static Armor BronzeShield { get { return new Armor("Bronze Shield", 4.0, 5.0, 20.0, 1.0); } }
        public static Armor IronShield { get { return new Armor("Iron Shield", 8.0, 6.0, 30.0, 1.0); } }
        public static Armor SteelShield { get { return new Armor("Steel Shield", 16.0, 6.0, 50.0, 1.0); } }
        */
        public Armor(ArmorCategory category, Material material, double value, double weight, double maxArmorPoints, double minArmorPoints)
        {
            Category = category;
            Material = material;

            var name = Material.Name + Category.Name;
            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            Name = name;
            Value = value;
            Weight = weight;
            MaxArmorPoints = maxArmorPoints;
            MinArmorPoints = minArmorPoints;
        }

        public Armor(Armor armor)
        {
            Category = armor.Category;
            Material = armor.Material;
            Name = armor.Name;
            Value = armor.Value;
            Weight = armor.Weight;
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
        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
        public double MaxArmorPoints { get; }
        public double MinArmorPoints { get; }
    }
}
