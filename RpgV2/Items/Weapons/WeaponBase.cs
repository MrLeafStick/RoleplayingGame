using RpgV2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public abstract class WeaponBase : ItemBase
    {
        private double _maxDamage;

        protected WeaponBase(double maxDamage)
        {
            _maxDamage = maxDamage;
        }

        public virtual double Damage
        {
            get { return RNG.RandomDouble(0.0, _maxDamage); }
        }
    }
}
