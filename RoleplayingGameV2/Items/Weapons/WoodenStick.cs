using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Items.Weapons
{
    public class WoodenStick : WeaponBase
    {
        public WoodenStick() : base()
        {
        }

        public override int TotalMaxWeaponDamage { get { return 5; } }
        public override int TotalMinWeaponDamage { get { return 1; } }

        public override string Name { get { return "Wooden Stick"; } }
    }
}
