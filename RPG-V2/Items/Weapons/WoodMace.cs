using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Items.Weapons
{
    public class WoodMace : WeaponBase
    {
        public WoodMace() : base()
        {
        }

        public override string Description
        {
            get { return "Rough wooden mace"; }
        }

        public override int TotalMaxWeaponDamage { get; }
        public override string Name { get; }
    }
}
