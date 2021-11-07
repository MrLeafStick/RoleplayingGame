using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    class WoodenMace : WeaponBase
    {
        private string _name;

        public WoodenMace(string name, int minWeaponDamage, int maxWeaponDamage) : base(minWeaponDamage, maxWeaponDamage)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "Rough Wooden Mace"; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
