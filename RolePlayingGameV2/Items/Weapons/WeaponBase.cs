using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;

namespace RolePlayingGameV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int MinWeaponDamage { get; }

        public int MaxWeaponDamage { get; }

        public int WeaponDamage { get; }

        protected WeaponBase (int minDamage, int maxDamage) 
        {
            MinWeaponDamage = minDamage;
            MaxWeaponDamage = maxDamage;
            WeaponDamage = RNG.RandomInt(MinWeaponDamage, MaxWeaponDamage);
        }

        public override string Description { get { return $"{Name} (max. {WeaponDamage} weapon damage)"; } }
        public abstract string Name { get; }
    }
}

//TODO Fix the rest of the weapon class to reflect the new strcuture...
