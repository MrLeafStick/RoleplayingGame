using RPGv2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Weapons
{
    public abstract class WeaponBase : itemBase
    {
        private double _maxDamage;

        protected WeaponBase(double maxDamage)
        {
            _maxDamage = maxDamage;
        }

        public virtual double damage
        {
            get { return RNG.RandomDouble(0.0, _maxDamage); }
        }
    }
}
