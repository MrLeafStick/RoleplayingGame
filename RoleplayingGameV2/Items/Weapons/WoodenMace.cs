using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGameV2.Items.Weapons
{
    public class WoodenMace : WeaponBase
    {
        public WoodenMace() : base()
        {
        }

        public override int TotalMaxWeaponDamage { get { return 30; } }
        public override int TotalMinWeaponDamage { get { return 10; } }

        public override string Name { get { return "Rough Wooden Mace"; } }
    }
}
