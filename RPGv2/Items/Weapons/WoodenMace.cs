using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Weapons
{
    class WoodenMace : WeaponBase
    {
        public WoodenMace() : base(20)
        {
        }

        public override string Description
        {
            get { return " Rough Wooden Mace "; }
        }
    }
}
