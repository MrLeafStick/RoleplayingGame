using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    class SteelLance : WeaponBase
    {
        public SteelLance() : base()
        {

        }

        public override string Description
        {
            get { return "Sharpened steel lance"; }
        }
        public override int TotalMinWeaponDamage
        {
            get { return 10; }
        }
        public override int TotalMaxWeaponDamage
        {
            get { return 15; }
        }

        public override string Name
        {
            get { return Name; }
        }
    }
}
