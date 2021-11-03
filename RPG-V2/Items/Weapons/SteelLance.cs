using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Weapons
{
    public class SteelLance : WeaponBase
    {
        public SteelLance() : base(75)
        {

        }

        public override string Description
        {
            get { return "Sharpened steel lance"}
        }
    }
}
