using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public class WoodenMace : WeaponBase
    {
        public WoodenMace() : base(30)
        {

        }

        public override string Description
        {
            get { return "Rough Wooden Mace"; }
        }
    }
}
