using RPG_V3.Interfaces;

namespace RPG_V3.Items
{
    class Weapon : Item, IWeapon
    {

        /*
         * Custom (non auto-generated) weapons goes here:
        public static Weapon WoodenSword { get { return new Weapon("Wooden Sword", 4.0, 1.0, 10.0, 1.0); } }
        */

        public Weapon(WeaponCategory category, Material material, double value, double weight, double maxDamage) 
            : base(value, weight)
        {
            Category = category;
            Material = material;

            var name = Material.Name + Category.Name;

            Name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1); ;
            MaxDamagePoints = maxDamage;
        }

        public Weapon(Weapon weapon) : base(weapon)
        {
            Category = weapon.Category;
            Material = weapon.Material;
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
        public Material Material { get; } // TODO: move material to Item

        public double MaxDamagePoints { get; }
        public double MinDamagePoints { get; }
    }
}
