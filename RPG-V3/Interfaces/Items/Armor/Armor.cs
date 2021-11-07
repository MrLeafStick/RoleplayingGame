using System.Collections.Generic;

namespace RPG_V3.Interfaces.Items.Armor
{
    class Armor : IArmor
    {
        public static Armor WoodenShield { get { return new Armor("Wooden Shield", 1.0, 3.0, 10.0, 1.0); } }
        public static Armor LeatherShield { get { return new Armor("Leather Shield", 2.0, 4.0, 15.0, 1.0); } }
        public static Armor BronzeShield { get { return new Armor("Bronze Shield", 4.0, 5.0, 20.0, 1.0); } }
        public static Armor IronShield { get { return new Armor("Iron Shield", 8.0, 6.0, 30.0, 1.0); } }
        public static Armor SteelShield { get { return new Armor("Steel Shield", 16.0, 6.0, 50.0, 1.0); } }

        private Armor(string name, double value, double weight, double maxArmorPoints, double minArmorPoints)
        {
            Name = name;
            Value = value;
            Weight = weight;
            MaxArmorPoints = maxArmorPoints;
            MinArmorPoints = minArmorPoints;
        }

        public Armor(Armor armor)
        {
            Name = armor.Name;
            Value = armor.Value;
            Weight = armor.Weight;
            MaxArmorPoints = armor.MaxArmorPoints;
            MinArmorPoints = armor.MinArmorPoints;
        }

        public static List<Armor> List()
        {
            return new List<Armor> { WoodenShield, LeatherShield, BronzeShield, IronShield, SteelShield };
        }

        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
        public double MaxArmorPoints { get; }
        public double MinArmorPoints { get; }
    }
}
