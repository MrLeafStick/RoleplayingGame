using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;

namespace RolePlayingGameV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int MinWeaponDamage { get; private set; }

        public int MaxWeaponDamage { get; private set; }

        private double _maxDamage;
        protected WeaponBase (double maxDamage) 
        {
            MaxWeaponDamage = RNG.RandomInt(1, TotalMaxWeaponDamage);
            //TODO min weapon dmg...
        }

        public override string Description { get { return $"{Name} (max. {TotalMaxWeaponDamage} weapon damage)"; } }

        public abstract int TotalMaxWeaponDamage { get; }
        public abstract string Name { get; }
    }
}

//TODO Fix the rest of the weapon class to reflect the new strcuture...
