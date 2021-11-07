using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;

namespace RoleplayingGameV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int WeaponDamage { get; }

        protected WeaponBase()
        {
            WeaponDamage = RNG.RandomInt(TotalMinWeaponDamage, TotalMaxWeaponDamage);
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
