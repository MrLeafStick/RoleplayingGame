using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    class SteelLance : WeaponBase
    {
        private string _name;

        public SteelLance(string name, int minWeaponDamage, int maxWeaponDamage) : base(minWeaponDamage, maxWeaponDamage)
        {
            _name = name;
        }

        public override string Description
        {
            get { return "Sharpned steel lance"; }
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}
