using RPG_V3.Interfaces.Items;
using System.Collections.Generic;

namespace RPG_V3.Items
{
    class WeaponCategory : IWeaponCategory
    {
        private WeaponCategory(string name) { Name = name; }
        
        public string Name { get; }
        public string MinDamage { get; }
        public string MaxDamage { get; }

        public static WeaponCategory Stick { get { return new WeaponCategory("stick"); } }
        public static WeaponCategory Club { get { return new WeaponCategory("club"); } }
        public static WeaponCategory Knife { get { return new WeaponCategory("knife"); } }
        public static WeaponCategory Dagger { get { return new WeaponCategory("dagger"); } }
        public static WeaponCategory Sword { get { return new WeaponCategory("sword"); } }
        public static WeaponCategory Axe { get { return new WeaponCategory("axe"); } }
        public static WeaponCategory Spear { get { return new WeaponCategory("spear"); } }

        public static List<WeaponCategory> List()
        {
            return new List<WeaponCategory> { Stick, Club, Knife, Dagger, Sword, Axe, Spear };
        }
    }
}
