using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Weapons
{
    class SteelLance : WeaponBase
    {
        public SteelLance() : base(60)
        {
        }
        public override string Description
        {
            get { return " Sharpened Steel Lance"; }
        }
    }
}
