using RpgV2.Helpers;
using RpgV2.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase, IWeapon
    {
        //public int MaxWeaponDamage { get; private set; }
        //public int MinWeaponDamage { get; private set; }
        public int TotalWeaponDamage { get; }

        protected WeaponBase()
        {
            //MinWeaponDamage = RNG.RandomInt(0, TotalMinWeaponDamage);
            //MaxWeaponDamage = RNG.RandomInt(MinWeaponDamage, TotalMaxWeaponDamage);
            //_maxDamage = maxDamage;
            TotalWeaponDamage = RNG.RandomInt(TotalMinWeaponDamage, TotalMaxWeaponDamage);
        }

        public override string Description
        {
            get { return $"{Name} (weapon range: {TotalMinWeaponDamage} to {TotalMaxWeaponDamage} weapon damage)"; }
        }
        public abstract int TotalMaxWeaponDamage { get; }
        public abstract int TotalMinWeaponDamage { get; }
        public abstract string Name { get; }


        /*
public virtual double Damage
{
get { return RNG.RandomDouble(0.0, _maxDamage); }
}
*/
    }
}

