using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Weapons
{
    class BronzeDagger : WeaponBase
    {
        public BronzeDagger() : base()
        {

        }

        public override string Description
        {
            get { return "One-handed Bronze Dagger"; }
        }

        public override int TotalMaxWeaponDamage { get; }
        public override string Name { get; }
    }
}
