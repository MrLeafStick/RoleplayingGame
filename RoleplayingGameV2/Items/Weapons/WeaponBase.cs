using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;

namespace RoleplayingGameV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int MaxWeaponDamage { get; private set; }

        public int MinWeaponDamage { get; private set; }

        protected WeaponBase()
        {
            MaxWeaponDamage = RNG.RandomInt(1, TotalMaxWeaponDamage);
            MinWeaponDamage = RNG.RandomInt(1, TotalMinWeaponDamage);
            // TODO: MIN WEP DMG
        }

        public override string Description
        {
            get { return $"{Name} (max. {TotalMaxWeaponDamage} weapon damage)"; }
        }

        public abstract int TotalMaxWeaponDamage { get; }
        public abstract int TotalMinWeaponDamage { get; }
        public abstract string Name { get; }
    }
}
