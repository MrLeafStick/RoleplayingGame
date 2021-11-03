using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Items.Weapons
{
    public class WoodenStick : WeaponBase
    {
        public WoodenStick() : base(5)
        {
        }

        public override string Description
        {
            get { return "Wooden Stick"; }
        }
    }
}
