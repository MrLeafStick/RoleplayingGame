using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Interfaces.Items.Weapons
{
    class Weapon : IWeapon
    {
        public static Weapon WoodenSword { get { return new Weapon("Wooden Sword", 1.0, 5.0, 10.0, 1.0); } }
        public static Weapon FlintSword { get { return new Weapon("Flint Sword", 1.0, 5.0, 10.0, 1.0); } }
        public static Weapon BronzeSword { get { return new Weapon("Bronze Sword", 1.0, 5.0, 10.0, 1.0); } }
        public static Weapon IronSword { get { return new Weapon("Iron Sword", 1.0, 5.0, 10.0, 1.0); } }
        public static Weapon SteelSword { get { return new Weapon("Steel Sword", 1.0, 5.0, 10.0, 1.0); } }

        private Weapon(string name, double value, double weight, double maxDamagePoints, double minDamagePoints)
        {
            Name = name;
            Value = value;
            Weight = weight;
            MaxDamagePoints = maxDamagePoints;
            MinDamagePoints = minDamagePoints;
        }

        public Weapon(Weapon weapon)
        {
            Name = weapon.Name;
            Value = weapon.Value;
            Weight = weapon.Weight;
            MaxDamagePoints = weapon.MaxDamagePoints;
            MinDamagePoints = weapon.MinDamagePoints;
        }

        public static List<Weapon> List()
        {
            return new List<Weapon> { WoodenSword, FlintSword, BronzeSword, IronSword, SteelSword };
        }

        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
        public double MaxDamagePoints { get; }
        public double MinDamagePoints { get; }
    }
}
