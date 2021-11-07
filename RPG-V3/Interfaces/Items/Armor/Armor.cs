using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Interfaces.Items.Armor
{
    class Armor : IArmor
    {
        public static Armor WoodenShield    { get { return new Armor("Wooden Shield", 1.0, 5.0, 10.0, 1.0); } }
        public static Armor LeatherShield   { get { return new Armor("Leather Shield", 1.0, 5.0, 10.0, 1.0); } }
        public static Armor BronzeShield    { get { return new Armor("Bronze Shield", 1.0, 5.0, 10.0, 1.0); } }
        public static Armor IronShield      { get { return new Armor("Iron Shield", 1.0, 5.0, 10.0, 1.0); } }
        public static Armor SteelShield     { get { return new Armor("Steel Shield", 1.0, 5.0, 10.0, 1.0); } }

        private Armor(string name, double value, double weight, double maxArmorPoints, double minArmorPoints) 
        {
            Name = name;
            Value = value;
            Weight = weight;
            MaxArmorPoints = maxArmorPoints;
            MinArmorPoints = minArmorPoints;
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
