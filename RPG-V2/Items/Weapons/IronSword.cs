using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword() : base(40)
        {

        }

        public override string Description
        {
            get { return "One-handed Iron Sword"; }
        }
    }
}
