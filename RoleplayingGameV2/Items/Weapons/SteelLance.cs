using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Items.Weapons
{
    public class SteelLance : WeaponBase
    {
        public SteelLance() : base(75)
        {
        }

        public override string Description
        {
            get { return "Sharpned Steel Lance"; }
        }
    }
}
