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
        public int AverageWeaponDamage { get; private set; }

        protected WeaponBase(int minWeaponDamage, int maxWeaponDamage)
        {
            MinWeaponDamage = minWeaponDamage;
            MaxWeaponDamage = maxWeaponDamage;
            AverageWeaponDamage = (minWeaponDamage + maxWeaponDamage) / 2;
        }

        public override string Description
        {
            get { return $"{Name} (max. {MaxWeaponDamage} weapon damage)"; }
        }
        public abstract string Name { get; }

        
    }
}

