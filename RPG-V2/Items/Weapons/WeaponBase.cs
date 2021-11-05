using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int MaxWeaponDamage { get; private set; }
        public int MinWeaponDamage { get; private set; }

        protected WeaponBase()
        {
            MaxWeaponDamage = RNG.RandomInt(1, TotalMaxWeaponDamage); //TODO: Min Weapon Damage
        }

        public override string Description
        {
            get { return $"{Name} (max {TotalMaxWeaponDamage} damage)"; }
        }

        public abstract int TotalMaxWeaponDamage { get; }
        //public abstract int TotalMinWeaponDamage { get; }
        public abstract string Name { get; }
    }
}

// TODO: Fix the rest of the weapon class's to  reflect the new infrastructure.

// TODO: Add base weapons like Bite, Kick, Hit.
