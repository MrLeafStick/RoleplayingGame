using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword(): base()
        {
        }
        public override int TotalMinWeaponDamage
        {
            get { return 5; }
        }
        public override int TotalMaxWeaponDamage
        {
            get { return 10; }
        }

        public override string Name
        {
            get { return "One handed Iron Sword"; }
        }
    }
}
