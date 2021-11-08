using RPG_V3.Interfaces;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class Weapon : IWeapon
    {
        
        /*
         * Custom (non auto-generated) weapons goes here:
        public static Weapon WoodenSword { get { return new Weapon("Wooden Sword", 4.0, 1.0, 10.0, 1.0); } }
        public static Weapon FlintSword { get { return new Weapon("Flint Sword", 8.0, 2.0, 50.0, 1.0); } }
        public static Weapon BronzeSword { get { return new Weapon("Bronze Sword", 16.0, 2.0, 50.0, 1.0); } }
        public static Weapon IronSword { get { return new Weapon("Iron Sword", 24.0, 5.0, 80.0, 1.0); } }
        public static Weapon SteelSword { get { return new Weapon("Steel Sword", 32.0, 5.0, 100.0, 1.0); } }
        public static Weapon IceSword { get { return new Weapon("Steel Sword", 32.0, 5.0, 100.0, 1.0); } }
        */

        public Weapon(WeaponCategory category, Material material, double value, double weight, double maxDamage)
        {
            Category = category;
            Material = material;
            Name = $"{Material.Name} {Category.Name}";
            Value = value;
            Weight = weight;
            MaxDamagePoints = maxDamage;
        }

        public Weapon(Weapon weapon)
        {
            Category = weapon.Category;
            Material = weapon.Material;
            Name = weapon.Name;
            Value = weapon.Value;
            Weight = weapon.Weight;
            MaxDamagePoints = weapon.MaxDamagePoints;
            MinDamagePoints = weapon.MinDamagePoints;
        }

        /*
        public static List<Weapon> List()
        {
            return new List<Weapon> { IceSword, WoodenSword, FlintSword, BronzeSword, IronSword, SteelSword };
        }
        */

        public WeaponCategory Category { get; }
        public Material Material { get; }
        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
        public double MaxDamagePoints { get; }
        public double MinDamagePoints { get; }
    }
}
