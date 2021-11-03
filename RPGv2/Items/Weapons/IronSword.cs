using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword() : base(40)
        {

        }

        public override string Description
        {
            get { return "One-Handed Iron Sword"; }
        }
    }
}
