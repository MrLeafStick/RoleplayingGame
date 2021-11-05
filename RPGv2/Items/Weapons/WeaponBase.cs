using RpgV2.Helpers;
using RpgV2.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        public int MaxWeaponDamage { get; private set; }
        public int MinWeaponDamage { get; private set; }


        protected WeaponBase()
        {
            MinWeaponDamage = RNG.RandomInt(1, TotalMinWeaponDamage);
            MaxWeaponDamage = RNG.RandomInt(MinWeaponDamage, TotalMaxWeaponDamage);
        }

        public override string Description
        {
            get { return $"{Name} (max. {TotalMaxWeaponDamage} weapon damage)"; }
        }
        public abstract int TotalMinWeaponDamage { get; }
        public abstract int TotalMaxWeaponDamage { get; }
        public abstract string Name { get; }
    }
}

