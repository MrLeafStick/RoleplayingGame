using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Items.Weapons
{
    public class WoodenMace : WeaponBase
    {
        public WoodenMace() : base()
        {

        }

        public override string Description
        {
            get { return "Rough Wooden Mace"; }
        }
        public override int TotalMinWeaponDamage
        {
            get { return 1; }
        }
        public override int TotalMaxWeaponDamage
        {
            get { return 3; }
        }

        public override string Name
        {
            get { return base.Description; }
        }
    }
}
