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
            MaxWeaponDamage = RNG.RandomInt(1, TotalMaxWeaponDamage);
            //TODO: MIN WEP DMG
        }

        public override string Description
        {
            get { return $"{Name} (max. {TotalMaxWeaponDamage} weapon damage)"; }
        }

        public abstract int TotalMaxWeaponDamage { get; }
        public abstract string Name { get; }
    }
}

//TODO: Fix the rest of the weapons class's to reflect the new infrastructure.

